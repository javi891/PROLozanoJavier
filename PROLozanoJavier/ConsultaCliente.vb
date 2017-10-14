Imports System.Data.SqlClient

Public Class ConsultaCliente

    Private Sub ConsultaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clientes.cargarDatosConsulta()

    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim sSQL As String
        'Dim fecha As Date = Now

        sSQL = "UPDATE Clientes SET NOMBRE = '" & txtNombre.Text & "',APELLIDO1='" & txtApellido.Text & "',APELLIDO2='" & txtApellido2.Text & "',CIUDAD='" & txtCiudad.Text & "',DNI='" & txtDNI.Text & "',DIRECCION='" & txtDireccion.Text & "',COD_POSTAL=" & txtCodPostal.Text & ",FECHA_NACI='" & Format(CType(mskFecha.Text, Date), "yyyy-MM-dd") & "',TELEFONO=" & txtTelefono.Text & "WHERE COD_CLIENTE =" & txtCodCliente.Text & ""
        Dim cmd As New SqlCommand(sSQL, Conexion)
        Conexion.Open()
        Dim iResultado As Integer
        ' ejecutar comando
        iResultado = cmd.ExecuteNonQuery()
        ' cerrar conexión
        Conexion.Close()
        MessageBox.Show("Registros modificados:" & iResultado)
        Clientes.CheckedListBox1.Items.Clear()
        Clientes.CargarDatos()
        Me.Close()

    End Sub

    Private Sub txtCodCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCliente.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtNomCon.Focus()
            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Formato introducido incorrecto")
        End If

        Me.txtApellido.Text = Trim(Replace(Me.txtApellido.Text, " ", ""))
        txtApellido.Select(txtApellido.Text.Length, 0)

    End Sub

    Private Sub txtApellido2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido2.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Formato introducido incorrecto")
        End If

        Me.txtApellido2.Text = Trim(Replace(Me.txtApellido2.Text, " ", ""))
        txtApellido2.Select(txtApellido2.Text.Length, 0)

    End Sub


    Private Sub txtCodPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPostal.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtNomCon.Focus()
            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Formato introducido incorrecto")
        End If

        Me.txtNombre.Text = Trim(Replace(Me.txtNombre.Text, " ", ""))
        txtNombre.Select(txtNombre.Text.Length, 0)

    End Sub





    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress

        If txtDNI.TextLength < 8 Then
            Select Case e.KeyChar
                Case ChrW(8) '8 borrar
                Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
                Case Else 'todo lo demas no se escribe
                    e.KeyChar = ChrW(0)
            End Select
        ElseIf txtDNI.TextLength = 8 Then
            Select Case e.KeyChar
                Case ChrW(8) '8 borrar
                Case Else 'cualquier cosa escribe el numero del DNI
                    txtDNI.Text = txtDNI.Text & Calcular_NIF(txtDNI.Text, True)
            End Select
        Else
            Select Case e.KeyChar
                Case ChrW(8) '8 borrar
                    txtDNI.Text = ""
                Case Else 'todo lo demas no se escribe
                    e.KeyChar = ChrW(0)
            End Select
        End If

    End Sub
    Public Function Calcular_NIF(ByVal dni As String, ByVal retornoLetra As Boolean) As String
        Dim resto As Integer
        Dim letra_NIF As String
        letra_NIF = ""
        If dni = "" Then
            MsgBox("No se ha introducido datos", MsgBoxStyle.Information)
            Calcular_NIF = ""
            Exit Function
        ElseIf Len(dni) < 7 Then
            MsgBox("No se puede calcular el NIF porque faltan dígitos", MsgBoxStyle.Information)
            Calcular_NIF = ""
            Exit Function
        ElseIf Not IsNumeric(dni) Then
            MsgBox("El dato introducido no es numérico", MsgBoxStyle.Information)
            Calcular_NIF = ""
            Exit Function
        Else
            resto = Val(dni) Mod 23
            Select Case resto
                Case 0
                    letra_NIF = "T"
                Case 1
                    letra_NIF = "R"
                Case 2
                    letra_NIF = "W"
                Case 3
                    letra_NIF = "A"
                Case 4
                    letra_NIF = "G"
                Case 5
                    letra_NIF = "M"
                Case 6
                    letra_NIF = "Y"
                Case 7
                    letra_NIF = "F"
                Case 8
                    letra_NIF = "P"
                Case 9
                    letra_NIF = "D"
                Case 10
                    letra_NIF = "X"
                Case 11
                    letra_NIF = "B"
                Case 12
                    letra_NIF = "N"
                Case 13
                    letra_NIF = "J"
                Case 14
                    letra_NIF = "Z"
                Case 15
                    letra_NIF = "S"
                Case 16
                    letra_NIF = "Q"
                Case 17
                    letra_NIF = "V"
                Case 18
                    letra_NIF = "H"
                Case 19
                    letra_NIF = "L"
                Case 20
                    letra_NIF = "C"
                Case 21
                    letra_NIF = "K"
                Case 22
                    letra_NIF = "E"

            End Select
            If retornoLetra = True Then
                Return letra_NIF
            Else
                Return dni & letra_NIF
            End If

            Exit Function
        End If

    End Function

End Class