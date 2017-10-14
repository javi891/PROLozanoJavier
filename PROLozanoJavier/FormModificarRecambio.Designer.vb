<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificarRecambio
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
        Me.txtModifCant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtModifprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModificarRe = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModCodpieza = New System.Windows.Forms.TextBox()
        Me.btnEliminarReg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtModifCant
        '
        Me.txtModifCant.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModifCant.Location = New System.Drawing.Point(110, 55)
        Me.txtModifCant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModifCant.MaxLength = 4
        Me.txtModifCant.Name = "txtModifCant"
        Me.txtModifCant.Size = New System.Drawing.Size(56, 20)
        Me.txtModifCant.TabIndex = 179
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "CANTIDAD:"
        '
        'txtModifprecio
        '
        Me.txtModifprecio.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModifprecio.Location = New System.Drawing.Point(87, 86)
        Me.txtModifprecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModifprecio.MaxLength = 8
        Me.txtModifprecio.Name = "txtModifprecio"
        Me.txtModifprecio.Size = New System.Drawing.Size(79, 20)
        Me.txtModifprecio.TabIndex = 177
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "PRECIO:"
        '
        'btnModificarRe
        '
        Me.btnModificarRe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModificarRe.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRe.Location = New System.Drawing.Point(140, 117)
        Me.btnModificarRe.Name = "btnModificarRe"
        Me.btnModificarRe.Size = New System.Drawing.Size(218, 32)
        Me.btnModificarRe.TabIndex = 180
        Me.btnModificarRe.Text = "MODIFICAR CANTIDAD Y PRECIO"
        Me.btnModificarRe.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "COD PIEZA:"
        '
        'txtModCodpieza
        '
        Me.txtModCodpieza.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModCodpieza.Location = New System.Drawing.Point(110, 24)
        Me.txtModCodpieza.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModCodpieza.MaxLength = 4
        Me.txtModCodpieza.Name = "txtModCodpieza"
        Me.txtModCodpieza.Size = New System.Drawing.Size(56, 20)
        Me.txtModCodpieza.TabIndex = 182
        '
        'btnEliminarReg
        '
        Me.btnEliminarReg.BackColor = System.Drawing.Color.PowderBlue
        Me.btnEliminarReg.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarReg.Location = New System.Drawing.Point(140, 164)
        Me.btnEliminarReg.Name = "btnEliminarReg"
        Me.btnEliminarReg.Size = New System.Drawing.Size(218, 36)
        Me.btnEliminarReg.TabIndex = 181
        Me.btnEliminarReg.Text = "ELIMINAR RECAMBIOS"
        Me.btnEliminarReg.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(187, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 30)
        Me.Button1.TabIndex = 184
        Me.Button1.Text = "MODIFICAR CANTIDAD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(187, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 30)
        Me.Button2.TabIndex = 185
        Me.Button2.Text = "MODIFICAR PRECIO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormModificarRecambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.grey_triangles_background_23_2147494297
        Me.ClientSize = New System.Drawing.Size(370, 234)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtModCodpieza)
        Me.Controls.Add(Me.btnEliminarReg)
        Me.Controls.Add(Me.btnModificarRe)
        Me.Controls.Add(Me.txtModifCant)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtModifprecio)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormModificarRecambio"
        Me.Text = "FormModificarRecambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtModifCant As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtModifprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnModificarRe As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtModCodpieza As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarReg As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
