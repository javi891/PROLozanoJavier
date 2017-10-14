<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Coches))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CochesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodCl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomCon = New System.Windows.Forms.TextBox()
        Me.txtCodClient = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodcoche = New System.Windows.Forms.TextBox()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.txtBastidor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cbxMarca = New System.Windows.Forms.ComboBox()
        Me.DataCoche = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txtKilometros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtFiltroMatri = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFiltroKilom = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txtFiltroBasti = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.txtFiltroCod = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFiltroMode = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFiltroMarca = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.pbmodelos = New System.Windows.Forms.PictureBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CochesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnInserIm = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataCoche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmodelos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CochesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CochesToolStripMenuItem, Me.RecambiosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1015, 25)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.ClientesToolStripMenuItem.Text = "Inicio"
        '
        'CochesToolStripMenuItem
        '
        Me.CochesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CochesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CochesToolStripMenuItem.Name = "CochesToolStripMenuItem"
        Me.CochesToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.CochesToolStripMenuItem.Text = "Clientes"
        '
        'RecambiosToolStripMenuItem
        '
        Me.RecambiosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecambiosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RecambiosToolStripMenuItem.Name = "RecambiosToolStripMenuItem"
        Me.RecambiosToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.RecambiosToolStripMenuItem.Text = "Salir"
        '
        'txtCodCl
        '
        Me.txtCodCl.AutoSize = True
        Me.txtCodCl.BackColor = System.Drawing.Color.Transparent
        Me.txtCodCl.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCl.ForeColor = System.Drawing.Color.Black
        Me.txtCodCl.Location = New System.Drawing.Point(22, 44)
        Me.txtCodCl.Name = "txtCodCl"
        Me.txtCodCl.Size = New System.Drawing.Size(82, 18)
        Me.txtCodCl.TabIndex = 51
        Me.txtCodCl.Text = "COD CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "CONDUCTOR:"
        '
        'txtNomCon
        '
        Me.txtNomCon.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCon.Location = New System.Drawing.Point(128, 67)
        Me.txtNomCon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomCon.MaxLength = 20
        Me.txtNomCon.Name = "txtNomCon"
        Me.txtNomCon.ReadOnly = True
        Me.txtNomCon.Size = New System.Drawing.Size(107, 20)
        Me.txtNomCon.TabIndex = 46
        '
        'txtCodClient
        '
        Me.txtCodClient.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodClient.Location = New System.Drawing.Point(128, 44)
        Me.txtCodClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodClient.MaxLength = 4
        Me.txtCodClient.Name = "txtCodClient"
        Me.txtCodClient.ReadOnly = True
        Me.txtCodClient.Size = New System.Drawing.Size(57, 20)
        Me.txtCodClient.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "MARCA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Nº DE BASTIDOR:"
        '
        'txtCodcoche
        '
        Me.txtCodcoche.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodcoche.Location = New System.Drawing.Point(128, 90)
        Me.txtCodcoche.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodcoche.MaxLength = 4
        Me.txtCodcoche.Name = "txtCodcoche"
        Me.txtCodcoche.Size = New System.Drawing.Size(88, 20)
        Me.txtCodcoche.TabIndex = 65
        '
        'txtMotor
        '
        Me.txtMotor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotor.Location = New System.Drawing.Point(128, 218)
        Me.txtMotor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMotor.MaxLength = 5
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(134, 20)
        Me.txtMotor.TabIndex = 63
        '
        'txtBastidor
        '
        Me.txtBastidor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBastidor.Location = New System.Drawing.Point(134, 192)
        Me.txtBastidor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBastidor.MaxLength = 17
        Me.txtBastidor.Name = "txtBastidor"
        Me.txtBastidor.Size = New System.Drawing.Size(128, 20)
        Me.txtBastidor.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "COD COCHE:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.BackColor = System.Drawing.Color.Transparent
        Me.lblMatricula.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.ForeColor = System.Drawing.Color.Black
        Me.lblMatricula.Location = New System.Drawing.Point(23, 115)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(74, 18)
        Me.lblMatricula.TabIndex = 59
        Me.lblMatricula.Text = "MATRICULA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "MOTOR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "MODELO:"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(306, 487)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 28)
        Me.Button6.TabIndex = 69
        Me.Button6.Text = "ELIMINAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(112, 487)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(188, 28)
        Me.Button7.TabIndex = 68
        Me.Button7.Text = "MODIFICAR/CONSULTAR"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(14, 487)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(92, 28)
        Me.Button8.TabIndex = 67
        Me.Button8.Text = "INSERTAR "
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cbxMarca
        '
        Me.cbxMarca.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMarca.FormattingEnabled = True
        Me.cbxMarca.Location = New System.Drawing.Point(128, 138)
        Me.cbxMarca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxMarca.MaxLength = 10
        Me.cbxMarca.Name = "cbxMarca"
        Me.cbxMarca.Size = New System.Drawing.Size(107, 24)
        Me.cbxMarca.Sorted = True
        Me.cbxMarca.TabIndex = 71
        '
        'DataCoche
        '
        Me.DataCoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCoche.Location = New System.Drawing.Point(443, 303)
        Me.DataCoche.Name = "DataCoche"
        Me.DataCoche.Size = New System.Drawing.Size(543, 248)
        Me.DataCoche.TabIndex = 80
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightBlue
        Me.Button9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(92, 523)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(230, 28)
        Me.Button9.TabIndex = 81
        Me.Button9.Text = "SIGUIENTE FORMULARIO"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'txtKilometros
        '
        Me.txtKilometros.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilometros.Location = New System.Drawing.Point(128, 244)
        Me.txtKilometros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKilometros.MaxLength = 7
        Me.txtKilometros.Name = "txtKilometros"
        Me.txtKilometros.Size = New System.Drawing.Size(134, 20)
        Me.txtKilometros.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "KILOMETROS:"
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(25, 349)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 22)
        Me.Button5.TabIndex = 85
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtFiltroMatri
        '
        Me.txtFiltroMatri.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroMatri.Location = New System.Drawing.Point(105, 351)
        Me.txtFiltroMatri.MaxLength = 11
        Me.txtFiltroMatri.Name = "txtFiltroMatri"
        Me.txtFiltroMatri.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroMatri.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 18)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "BUSQUEDA DE COCHES:"
        '
        'txtFiltroKilom
        '
        Me.txtFiltroKilom.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroKilom.Location = New System.Drawing.Point(105, 400)
        Me.txtFiltroKilom.MaxLength = 7
        Me.txtFiltroKilom.Name = "txtFiltroKilom"
        Me.txtFiltroKilom.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroKilom.TabIndex = 89
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(25, 398)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(72, 22)
        Me.Button10.TabIndex = 88
        Me.Button10.Text = "Buscar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txtFiltroBasti
        '
        Me.txtFiltroBasti.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroBasti.Location = New System.Drawing.Point(302, 351)
        Me.txtFiltroBasti.MaxLength = 17
        Me.txtFiltroBasti.Name = "txtFiltroBasti"
        Me.txtFiltroBasti.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroBasti.TabIndex = 91
        '
        'Button11
        '
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(222, 349)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(72, 22)
        Me.Button11.TabIndex = 90
        Me.Button11.Text = "Buscar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtFiltroCod
        '
        Me.txtFiltroCod.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCod.Location = New System.Drawing.Point(302, 400)
        Me.txtFiltroCod.MaxLength = 4
        Me.txtFiltroCod.Name = "txtFiltroCod"
        Me.txtFiltroCod.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroCod.TabIndex = 93
        '
        'Button12
        '
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(222, 398)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(72, 22)
        Me.Button12.TabIndex = 92
        Me.Button12.Text = "Buscar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(22, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Busqueda por Matricula:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(225, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 16)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Busqueda por NºBastidor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(22, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 16)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Busqueda por Kilometros:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(225, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 16)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Busqueda por Codigo Coche:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(25, 429)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 16)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Busqueda por Modelo:"
        '
        'txtFiltroMode
        '
        Me.txtFiltroMode.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroMode.Location = New System.Drawing.Point(108, 450)
        Me.txtFiltroMode.MaxLength = 15
        Me.txtFiltroMode.Name = "txtFiltroMode"
        Me.txtFiltroMode.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroMode.TabIndex = 99
        '
        'Button13
        '
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(28, 448)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(72, 22)
        Me.Button13.TabIndex = 98
        Me.Button13.Text = "Buscar"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(225, 429)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 16)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "Busqueda por Marca:"
        '
        'txtFiltroMarca
        '
        Me.txtFiltroMarca.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroMarca.Location = New System.Drawing.Point(308, 450)
        Me.txtFiltroMarca.MaxLength = 15
        Me.txtFiltroMarca.Name = "txtFiltroMarca"
        Me.txtFiltroMarca.Size = New System.Drawing.Size(111, 20)
        Me.txtFiltroMarca.TabIndex = 102
        '
        'Button14
        '
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(228, 448)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(72, 22)
        Me.Button14.TabIndex = 101
        Me.Button14.Text = "Buscar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(163, 279)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(149, 26)
        Me.Button15.TabIndex = 104
        Me.Button15.Text = "ELIMINAR FILTROS"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'pbmodelos
        '
        Me.pbmodelos.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.skoda_superb
        Me.pbmodelos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbmodelos.Location = New System.Drawing.Point(482, 44)
        Me.pbmodelos.Name = "pbmodelos"
        Me.pbmodelos.Size = New System.Drawing.Size(262, 180)
        Me.pbmodelos.TabIndex = 105
        Me.pbmodelos.TabStop = False
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(340, 44)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 49)
        Me.Button3.TabIndex = 108
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(283, 44)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 49)
        Me.Button4.TabIndex = 107
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnInserIm
        '
        Me.btnInserIm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserIm.Location = New System.Drawing.Point(669, 230)
        Me.btnInserIm.Name = "btnInserIm"
        Me.btnInserIm.Size = New System.Drawing.Size(75, 23)
        Me.btnInserIm.TabIndex = 109
        Me.btnInserIm.Text = "..."
        Me.btnInserIm.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(128, 165)
        Me.txtModelo.MaxLength = 15
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(122, 20)
        Me.txtModelo.TabIndex = 110
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(128, 113)
        Me.txtMatricula.MaxLength = 7
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 111
        '
        'Coches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1015, 586)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.btnInserIm)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.pbmodelos)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtFiltroMarca)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFiltroMode)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFiltroCod)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.txtFiltroBasti)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.txtFiltroKilom)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFiltroMatri)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtKilometros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.DataCoche)
        Me.Controls.Add(Me.cbxMarca)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.txtCodcoche)
        Me.Controls.Add(Me.txtMotor)
        Me.Controls.Add(Me.txtBastidor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodCl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomCon)
        Me.Controls.Add(Me.txtCodClient)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Coches"
        Me.Text = "Coches"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataCoche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmodelos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CochesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CochesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCodCl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomCon As System.Windows.Forms.TextBox
    Friend WithEvents txtCodClient As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodcoche As System.Windows.Forms.TextBox
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtBastidor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents cbxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CochesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataCoche As System.Windows.Forms.DataGridView
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtFiltroMatri As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroKilom As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txtFiltroBasti As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents txtFiltroCod As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroMode As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroMarca As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents pbmodelos As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnInserIm As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
End Class
