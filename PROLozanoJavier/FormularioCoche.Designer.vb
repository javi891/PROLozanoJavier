<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCoche
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.btnInserIm = New System.Windows.Forms.Button()
        Me.pbmodelos = New System.Windows.Forms.PictureBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtKilometros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMarca = New System.Windows.Forms.ComboBox()
        Me.txtCodcoche = New System.Windows.Forms.TextBox()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.txtBastidor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodCl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomCon = New System.Windows.Forms.TextBox()
        Me.txtCodClient = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbmodelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.PowderBlue
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(252, 323)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 34)
        Me.Button6.TabIndex = 107
        Me.Button6.Text = "MODIFICAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.btnInserIm)
        Me.GroupBox1.Controls.Add(Me.pbmodelos)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtKilometros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxMarca)
        Me.GroupBox1.Controls.Add(Me.txtCodcoche)
        Me.GroupBox1.Controls.Add(Me.txtMotor)
        Me.GroupBox1.Controls.Add(Me.txtBastidor)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblMatricula)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodCl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomCon)
        Me.GroupBox1.Controls.Add(Me.txtCodClient)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 287)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CLIENTE: "
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(112, 107)
        Me.txtMatricula.MaxLength = 7
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 131
        '
        'btnInserIm
        '
        Me.btnInserIm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserIm.Location = New System.Drawing.Point(436, 195)
        Me.btnInserIm.Name = "btnInserIm"
        Me.btnInserIm.Size = New System.Drawing.Size(75, 23)
        Me.btnInserIm.TabIndex = 130
        Me.btnInserIm.Text = "..."
        Me.btnInserIm.UseVisualStyleBackColor = False
        '
        'pbmodelos
        '
        Me.pbmodelos.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.skoda_superb
        Me.pbmodelos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbmodelos.Location = New System.Drawing.Point(253, 19)
        Me.pbmodelos.Name = "pbmodelos"
        Me.pbmodelos.Size = New System.Drawing.Size(258, 170)
        Me.pbmodelos.TabIndex = 129
        Me.pbmodelos.TabStop = False
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(112, 158)
        Me.txtModelo.MaxLength = 15
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(125, 20)
        Me.txtModelo.TabIndex = 128
        '
        'txtKilometros
        '
        Me.txtKilometros.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilometros.Location = New System.Drawing.Point(112, 237)
        Me.txtKilometros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKilometros.MaxLength = 8
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(125, 20)
        Me.txtKilometros.TabIndex = 127
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "KILOMETROS:"
        '
        'cbxMarca
        '
        Me.cbxMarca.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMarca.FormattingEnabled = True
        Me.cbxMarca.Location = New System.Drawing.Point(112, 131)
        Me.cbxMarca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxMarca.MaxLength = 10
        Me.cbxMarca.Name = "cbxMarca"
        Me.cbxMarca.Size = New System.Drawing.Size(125, 24)
        Me.cbxMarca.Sorted = True
        Me.cbxMarca.TabIndex = 125
        '
        'txtCodcoche
        '
        Me.txtCodcoche.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodcoche.Location = New System.Drawing.Point(112, 83)
        Me.txtCodcoche.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodcoche.MaxLength = 4
        Me.txtCodcoche.Name = "txtCodcoche"
        Me.txtCodcoche.Size = New System.Drawing.Size(125, 20)
        Me.txtCodcoche.TabIndex = 123
        '
        'txtMotor
        '
        Me.txtMotor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotor.Location = New System.Drawing.Point(112, 211)
        Me.txtMotor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMotor.MaxLength = 10
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(125, 20)
        Me.txtMotor.TabIndex = 122
        '
        'txtBastidor
        '
        Me.txtBastidor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBastidor.Location = New System.Drawing.Point(118, 185)
        Me.txtBastidor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBastidor.MaxLength = 17
        Me.txtBastidor.Name = "txtBastidor"
        Me.txtBastidor.Size = New System.Drawing.Size(119, 20)
        Me.txtBastidor.TabIndex = 121
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "COD COCHE:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.BackColor = System.Drawing.Color.Transparent
        Me.lblMatricula.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.ForeColor = System.Drawing.Color.Black
        Me.lblMatricula.Location = New System.Drawing.Point(7, 108)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(74, 18)
        Me.lblMatricula.TabIndex = 119
        Me.lblMatricula.Text = "MATRICULA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "MOTOR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "MODELO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "MARCA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Nº DE BASTIDOR:"
        '
        'txtCodCl
        '
        Me.txtCodCl.AutoSize = True
        Me.txtCodCl.BackColor = System.Drawing.Color.Transparent
        Me.txtCodCl.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCl.ForeColor = System.Drawing.Color.Black
        Me.txtCodCl.Location = New System.Drawing.Point(6, 37)
        Me.txtCodCl.Name = "txtCodCl"
        Me.txtCodCl.Size = New System.Drawing.Size(82, 18)
        Me.txtCodCl.TabIndex = 114
        Me.txtCodCl.Text = "COD CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "CONDUCTOR:"
        '
        'txtNomCon
        '
        Me.txtNomCon.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCon.Location = New System.Drawing.Point(112, 60)
        Me.txtNomCon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomCon.MaxLength = 20
        Me.txtNomCon.Name = "txtNomCon"
        Me.txtNomCon.Size = New System.Drawing.Size(125, 20)
        Me.txtNomCon.TabIndex = 112
        '
        'txtCodClient
        '
        Me.txtCodClient.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodClient.Location = New System.Drawing.Point(112, 37)
        Me.txtCodClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodClient.MaxLength = 4
        Me.txtCodClient.Name = "txtCodClient"
        Me.txtCodClient.ReadOnly = True
        Me.txtCodClient.Size = New System.Drawing.Size(77, 20)
        Me.txtCodClient.TabIndex = 111
        '
        'FormularioCoche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.grey_triangles_background_23_2147494297
        Me.ClientSize = New System.Drawing.Size(668, 381)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioCoche"
        Me.Text = "FormularioCoche"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbmodelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtBastidor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodCl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomCon As System.Windows.Forms.TextBox
    Friend WithEvents txtCodClient As System.Windows.Forms.TextBox
    Friend WithEvents txtCodcoche As System.Windows.Forms.TextBox
    Friend WithEvents pbmodelos As System.Windows.Forms.PictureBox
    Friend WithEvents btnInserIm As System.Windows.Forms.Button
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
End Class
