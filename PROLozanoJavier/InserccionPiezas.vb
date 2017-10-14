Imports System.Data.SqlClient

Public Class InserccionPiezas

    Private Sub InsertarPieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click

        'Try
        If txtCodPiez.Text = "" Or richNombreRecamb.Text = "" Or txtPrecioUni.Text = "" Or txtcantidad.Text = "" Then

            MessageBox.Show("Hay campos vacios", _
    "Aviso", MessageBoxButtons.OK, _
    MessageBoxIcon.Error)

        ElseIf CInt(txtcantidad.Text) <= 0 Then

            MessageBox.Show("La cantidad no puede ser menor o igual a 0", _
    "Aviso", MessageBoxButtons.OK, _
    MessageBoxIcon.Error)
        ElseIf CDbl(txtPrecioUni.Text) = 0 Then

            MessageBox.Show("El precio de la unidad no puede ser igual a 0 o menor", _
    "Aviso", MessageBoxButtons.OK, _
    MessageBoxIcon.Error)
        Else
            Dim existe As Boolean = ExisteCodDPieza(txtCodPiez.Text)

            If (existe) Then
                MessageBox.Show("Ya existe el codigo de Pieza.")
                ' Abandonamos el procedimiento.
                Return
            End If
            Dim sqlInsert2 As String
            Dim existe2 As Boolean = ExisteNomPieza(richNombreRecamb.Text)
            If (existe2) Then
                MessageBox.Show("Ya existe el Nombre de recambio.")
                ' Abandonamos el procedimiento.
                Return
            End If
            sqlInsert2 = "INSERT INTO PIEZA (COD_PIEZA,NOMBRE_RECAMBIO,PRECIO,CANTIDAD)VALUES(" & txtCodPiez.Text & ",'" & richNombreRecamb.Text & "'," & txtPrecioUni.Text & "," & txtcantidad.Text & ")"
            '" & Me.txtNomCoch.Text & "'" & "," & "'" & Me.txtNomCon.Text & "'" & "," & Me.txtBast.Text & "," & "'" & Me.txtMarcCoche.Text & "'" & "," & Me.txtCodClient.Text & "," & "'" & Me.txtModelo.Text & "'" & "," & "'" & Me.txtTip.Text & "'" & "," & Me.txtCodcoche.Text & " 
            '(" & Me.txtCliente.Text & "," & "'" & Me.txtNombre.Text & "'" & "," & "'" & Me.txtFIngreso.Text & "'" & ")"
            Dim Comando As New SqlCommand(sqlInsert2, Conexion)

            If (Comando.Connection.State = ConnectionState.Closed) Then
                Comando.Connection.Open()
            End If
            Dim iResultado As Integer
            MessageBox.Show("Conectado")

            iResultado = Comando.ExecuteNonQuery()

            MessageBox.Show("Registros añadidos:" & iResultado)

            Conexion.Close()
            MessageBox.Show("Desconectado")
            Me.Close()
            txtCodPiez.Text = ""
            txtCodPiez.Text = ""
            txtcantidad.Text = ""
            txtPrecioUni.Text = ""
            richNombreRecamb.Text = ""

        End If
        ' Catch ex As Exception

        '     MessageBox.Show("No se puede insertar una pieza repetida", _
        '"Aviso", MessageBoxButtons.OK, _
        'MessageBoxIcon.Error)

        ' End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtPrecioUni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioUni.KeyPress

        Select Case e.KeyChar
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select

        If e.KeyChar = "," Then
            e.Handled = True
            txtPrecioUni.Text += "."c
            txtPrecioUni.SelectionStart = txtPrecioUni.Text.Length
        End If
    End Sub
        

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtNomCon.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtCodPiez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPiez.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtNomCon.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Friend Function ExisteCodDPieza(ByVal codPieza As Integer) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT COD_PIEZA FROM PIEZA WHERE COD_PIEZA=@COD_PIEZA"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@COD_PIEZA", txtCodPiez.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
    Friend Function ExisteNomPieza(ByVal cnombre As String) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT NOMBRE_RECAMBIO FROM PIEZA WHERE NOMBRE_RECAMBIO=@NOMBRE_RECAMBIO"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@NOMBRE_RECAMBIO", richNombreRecamb.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
End Class