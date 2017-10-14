<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mskComFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtComCiudad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtComCliente = New System.Windows.Forms.TextBox()
        Me.txtComTelefono = New System.Windows.Forms.TextBox()
        Me.txtComCodPostal = New System.Windows.Forms.TextBox()
        Me.txtComDireccion = New System.Windows.Forms.TextBox()
        Me.txtComDNI = New System.Windows.Forms.TextBox()
        Me.txtComApellido2 = New System.Windows.Forms.TextBox()
        Me.txtComApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComNombre = New System.Windows.Forms.TextBox()
        Me.txtComModelo = New System.Windows.Forms.TextBox()
        Me.txtComKilometros = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtComMatricula = New System.Windows.Forms.TextBox()
        Me.txtComCodcoche = New System.Windows.Forms.TextBox()
        Me.txtComMotor = New System.Windows.Forms.TextBox()
        Me.txtComBastidor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtComMarca = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContenido
        '
        Me.txtContenido.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContenido.Location = New System.Drawing.Point(335, 261)
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.ReadOnly = True
        Me.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContenido.Size = New System.Drawing.Size(355, 158)
        Me.txtContenido.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "COMPRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(157, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TOTAL:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(224, 308)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(74, 26)
        Me.txtTotal.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(172, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "IVA:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(71, 308)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(51, 26)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "21%"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskComFecha
        '
        Me.mskComFecha.Location = New System.Drawing.Point(166, 261)
        Me.mskComFecha.Mask = "00/00/0000"
        Me.mskComFecha.Name = "mskComFecha"
        Me.mskComFecha.ReadOnly = True
        Me.mskComFecha.Size = New System.Drawing.Size(100, 20)
        Me.mskComFecha.TabIndex = 111
        Me.mskComFecha.ValidatingType = GetType(Date)
        '
        'txtComCiudad
        '
        Me.txtComCiudad.Location = New System.Drawing.Point(128, 150)
        Me.txtComCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComCiudad.MaxLength = 15
        Me.txtComCiudad.Name = "txtComCiudad"
        Me.txtComCiudad.ReadOnly = True
        Me.txtComCiudad.Size = New System.Drawing.Size(138, 20)
        Me.txtComCiudad.TabIndex = 110
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "CIUDAD:"
        '
        'txtComCliente
        '
        Me.txtComCliente.Location = New System.Drawing.Point(128, 23)
        Me.txtComCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComCliente.MaxLength = 4
        Me.txtComCliente.Name = "txtComCliente"
        Me.txtComCliente.ReadOnly = True
        Me.txtComCliente.Size = New System.Drawing.Size(65, 20)
        Me.txtComCliente.TabIndex = 108
        '
        'txtComTelefono
        '
        Me.txtComTelefono.Location = New System.Drawing.Point(128, 234)
        Me.txtComTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComTelefono.MaxLength = 9
        Me.txtComTelefono.Name = "txtComTelefono"
        Me.txtComTelefono.ReadOnly = True
        Me.txtComTelefono.Size = New System.Drawing.Size(138, 20)
        Me.txtComTelefono.TabIndex = 107
        '
        'txtComCodPostal
        '
        Me.txtComCodPostal.Location = New System.Drawing.Point(144, 206)
        Me.txtComCodPostal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComCodPostal.MaxLength = 5
        Me.txtComCodPostal.Name = "txtComCodPostal"
        Me.txtComCodPostal.ReadOnly = True
        Me.txtComCodPostal.Size = New System.Drawing.Size(122, 20)
        Me.txtComCodPostal.TabIndex = 106
        '
        'txtComDireccion
        '
        Me.txtComDireccion.Location = New System.Drawing.Point(128, 178)
        Me.txtComDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComDireccion.MaxLength = 30
        Me.txtComDireccion.Name = "txtComDireccion"
        Me.txtComDireccion.ReadOnly = True
        Me.txtComDireccion.Size = New System.Drawing.Size(138, 20)
        Me.txtComDireccion.TabIndex = 105
        '
        'txtComDNI
        '
        Me.txtComDNI.Location = New System.Drawing.Point(128, 124)
        Me.txtComDNI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComDNI.MaxLength = 9
        Me.txtComDNI.Name = "txtComDNI"
        Me.txtComDNI.ReadOnly = True
        Me.txtComDNI.Size = New System.Drawing.Size(138, 20)
        Me.txtComDNI.TabIndex = 104
        '
        'txtComApellido2
        '
        Me.txtComApellido2.Location = New System.Drawing.Point(128, 99)
        Me.txtComApellido2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComApellido2.MaxLength = 15
        Me.txtComApellido2.Name = "txtComApellido2"
        Me.txtComApellido2.ReadOnly = True
        Me.txtComApellido2.Size = New System.Drawing.Size(138, 20)
        Me.txtComApellido2.TabIndex = 103
        '
        'txtComApellido
        '
        Me.txtComApellido.Location = New System.Drawing.Point(128, 74)
        Me.txtComApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComApellido.MaxLength = 15
        Me.txtComApellido.Name = "txtComApellido"
        Me.txtComApellido.ReadOnly = True
        Me.txtComApellido.Size = New System.Drawing.Size(138, 20)
        Me.txtComApellido.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "FECHA NACIMIENTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "COD CLIENTE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "TELEFONO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "CODIGO POSTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "DIRECCION:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "APELLIDO2:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "APELLIDO1:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "NOMBRE:"
        '
        'txtComNombre
        '
        Me.txtComNombre.Location = New System.Drawing.Point(128, 48)
        Me.txtComNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComNombre.MaxLength = 15
        Me.txtComNombre.Name = "txtComNombre"
        Me.txtComNombre.ReadOnly = True
        Me.txtComNombre.Size = New System.Drawing.Size(138, 20)
        Me.txtComNombre.TabIndex = 92
        '
        'txtComModelo
        '
        Me.txtComModelo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComModelo.Location = New System.Drawing.Point(438, 98)
        Me.txtComModelo.Name = "txtComModelo"
        Me.txtComModelo.ReadOnly = True
        Me.txtComModelo.Size = New System.Drawing.Size(76, 20)
        Me.txtComModelo.TabIndex = 129
        '
        'txtComKilometros
        '
        Me.txtComKilometros.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComKilometros.Location = New System.Drawing.Point(438, 179)
        Me.txtComKilometros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComKilometros.MaxLength = 8
        Me.txtComKilometros.Name = "txtComKilometros"
        Me.txtComKilometros.ReadOnly = True
        Me.txtComKilometros.Size = New System.Drawing.Size(76, 20)
        Me.txtComKilometros.TabIndex = 128
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(335, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "KILOMETROS:"
        '
        'txtComMatricula
        '
        Me.txtComMatricula.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComMatricula.Location = New System.Drawing.Point(438, 47)
        Me.txtComMatricula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComMatricula.MaxLength = 8
        Me.txtComMatricula.Name = "txtComMatricula"
        Me.txtComMatricula.ReadOnly = True
        Me.txtComMatricula.Size = New System.Drawing.Size(76, 20)
        Me.txtComMatricula.TabIndex = 125
        '
        'txtComCodcoche
        '
        Me.txtComCodcoche.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComCodcoche.Location = New System.Drawing.Point(438, 24)
        Me.txtComCodcoche.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComCodcoche.MaxLength = 4
        Me.txtComCodcoche.Name = "txtComCodcoche"
        Me.txtComCodcoche.ReadOnly = True
        Me.txtComCodcoche.Size = New System.Drawing.Size(76, 20)
        Me.txtComCodcoche.TabIndex = 124
        '
        'txtComMotor
        '
        Me.txtComMotor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComMotor.Location = New System.Drawing.Point(438, 151)
        Me.txtComMotor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComMotor.MaxLength = 10
        Me.txtComMotor.Name = "txtComMotor"
        Me.txtComMotor.ReadOnly = True
        Me.txtComMotor.Size = New System.Drawing.Size(76, 20)
        Me.txtComMotor.TabIndex = 123
        '
        'txtComBastidor
        '
        Me.txtComBastidor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComBastidor.Location = New System.Drawing.Point(438, 125)
        Me.txtComBastidor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComBastidor.MaxLength = 17
        Me.txtComBastidor.Name = "txtComBastidor"
        Me.txtComBastidor.ReadOnly = True
        Me.txtComBastidor.Size = New System.Drawing.Size(76, 20)
        Me.txtComBastidor.TabIndex = 122
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(333, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "COD COCHE:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.BackColor = System.Drawing.Color.Transparent
        Me.lblMatricula.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.ForeColor = System.Drawing.Color.Black
        Me.lblMatricula.Location = New System.Drawing.Point(332, 51)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(70, 16)
        Me.lblMatricula.TabIndex = 120
        Me.lblMatricula.Text = "MATRICULA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(335, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "MOTOR:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(335, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "MODELO:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(333, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 16)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "MARCA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(335, 124)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Nº DE BASTIDOR:"
        '
        'txtComMarca
        '
        Me.txtComMarca.Location = New System.Drawing.Point(438, 72)
        Me.txtComMarca.Name = "txtComMarca"
        Me.txtComMarca.ReadOnly = True
        Me.txtComMarca.Size = New System.Drawing.Size(76, 20)
        Me.txtComMarca.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(334, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(187, 20)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "CONCEPTOS DE COMPRA:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(304, 314)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 18)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "€"
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.grey_triangles_background_23_2147494297
        Me.ClientSize = New System.Drawing.Size(721, 428)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtComMarca)
        Me.Controls.Add(Me.txtComModelo)
        Me.Controls.Add(Me.txtComKilometros)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtComMatricula)
        Me.Controls.Add(Me.txtComCodcoche)
        Me.Controls.Add(Me.txtComMotor)
        Me.Controls.Add(Me.txtComBastidor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.mskComFecha)
        Me.Controls.Add(Me.txtComCiudad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtComCliente)
        Me.Controls.Add(Me.txtComTelefono)
        Me.Controls.Add(Me.txtComCodPostal)
        Me.Controls.Add(Me.txtComDireccion)
        Me.Controls.Add(Me.txtComDNI)
        Me.Controls.Add(Me.txtComApellido2)
        Me.Controls.Add(Me.txtComApellido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtComNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Compra"
        Me.Text = "Compra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mskComFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtComCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtComCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtComTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtComCodPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtComDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtComDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtComApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtComApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtComModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtComKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtComMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtComCodcoche As System.Windows.Forms.TextBox
    Friend WithEvents txtComMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtComBastidor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtComMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
