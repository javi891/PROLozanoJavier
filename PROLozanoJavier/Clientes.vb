Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Globalization

Public Class Clientes


    Private Sub insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim TestString As String = txtCodPostal.Text
        Dim subString As String = Microsoft.VisualBasic.Left(TestString, 2)
        Dim dateCheck As Boolean

        dateCheck = IsDate(mskFecha.Text)




        If txtCodCliente.Text = "" Then
            MessageBox.Show("El campo Codigo Cliente esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtNombre.Text = "" Then

            MessageBox.Show("El campo nombre esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtApellido.Text = "" Then

            MessageBox.Show("El campo Apellido esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)


        ElseIf txtCodCliente.Text = "" Then

            MessageBox.Show("El campo codigo Cliente esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtApellido2.Text = "" Then

            MessageBox.Show("El campo Apellido2 esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtDNI.Text = "" Then

            MessageBox.Show("El campo DNI esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)
        ElseIf txtCiudad.Text = "" Then

            MessageBox.Show("El campo Ciudad esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtDireccion.Text = "" Then

            MessageBox.Show("El campo Direccion esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtDNI.Text = "" Then

            MessageBox.Show("El campo DNI esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf Len(txtDNI.Text) < 8 Then

            MessageBox.Show("El campo DNI no puede tener menos de 8 caracteres", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtCodPostal.Text = "" Then

            MessageBox.Show("El campo codigo postal esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf mskFecha.Text = "" Then

            MessageBox.Show("El campo fecha esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtTelefono.Text = "" Then

            MessageBox.Show("El campo telefono esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)
        ElseIf Len(txtTelefono.Text) < 9 Then

            MessageBox.Show("El Telefono no puede tener menos de 9 digitos", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf subString > 50 Then
            MessageBox.Show("Las Iniciales del Codigo postal no pueden ser mayor de 50", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf dateCheck = False Then

            MessageBox.Show("El campo Fecha no tiene el formato correcto", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)
            
        Else

            Dim sqlInsert As String

            sqlInsert = "INSERT INTO Clientes VALUES(" & txtCodCliente.Text & ",'" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtApellido2.Text & "','" & txtDNI.Text & "','" & txtCiudad.Text & "','" & txtDireccion.Text & "'," & txtCodPostal.Text & ",'" & Format(CType(mskFecha.Text, Date), "yyyy-MM-dd") & "'," & txtTelefono.Text & ")"

            Dim existe As Boolean = ExisteCodCliente(txtCodCliente.Text)

            If (existe) Then
                MessageBox.Show("Ya existe el codigo de cliente.")
                ' Abandonamos el procedimiento.
                Return
            End If
            Dim existe2 As Boolean = ExisteCodDNI(txtDNI.Text)
            If (existe2) Then
                MessageBox.Show("Ya existe el DNI.")
                ' Abandonamos el procedimiento.
                Return
            End If

            'cmd = New SqlCommand
            

            Dim iResultado As Integer
            Dim cmd As New SqlCommand(sqlInsert, Conexion)
            If (cmd.Connection.State = ConnectionState.Closed) Then
                cmd.Connection.Open()
            End If
            'Conexion.Open()
            iResultado = cmd.ExecuteNonQuery()

            'Dim Comando As New OleDbCommand(sqlInsert, Conexion)
            MessageBox.Show("Cliente Insertado:" & iResultado)
            Conexion.Close()
            CheckedListBox1.Items.Clear()
            CargarDatos()
            txtCodCliente.Text = ""
            txtDNI.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtApellido2.Text = ""
            txtCiudad.Text = ""
            txtCodPostal.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            mskFecha.Text = ""
        End If
        'MessageBox.Show("Desconectado")



    End Sub
    Public Sub CargarDatos()

        Try
            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            '*******************************
            'Estas dos líneas hacen lo mismo.
            'Primera:
            Dim cmd As New SqlCommand("Select * from Clientes", Conexion)
            '
            'Segunda:
            'Dim sSQL As String
            'sSQL = "Select * from Clientes"
            '' crear comando
            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            Dim lectura As SqlDataReader
            'ListBox.Items.Clear()
            Dim cmd1 As New SqlCommand("SELECT * FROM Clientes", Conexion)
            If Not Conexion Is Nothing Then Conexion.Close()
            Conexion.Open()
            lectura = cmd1.ExecuteReader
            While lectura.Read()

                CheckedListBox1.Items.Add(CStr(lectura("COD_CLIENTE")) & " - " & CStr(lectura("NOMBRE")) & " - " & CStr(lectura("DNI")))

                ConsultaCliente.txtCodCliente.Text = CStr(lectura("COD_CLIENTE"))
                ConsultaCliente.txtDNI.Text = CStr(lectura("DNI"))
                ConsultaCliente.txtNombre.Text = CStr(lectura("NOMBRE"))
                ConsultaCliente.txtApellido.Text = CStr(lectura("APELLIDO1"))
                ConsultaCliente.txtApellido2.Text = CStr(lectura("APELLIDO2"))
                ConsultaCliente.txtCiudad.Text = CStr(lectura("CIUDAD"))
                ConsultaCliente.txtCodPostal.Text = CStr(lectura("COD_POSTAL"))
                ConsultaCliente.txtDireccion.Text = CStr(lectura("DIRECCION"))
                ConsultaCliente.txtTelefono.Text = CStr(lectura("TELEFONO"))
                ConsultaCliente.mskFecha.Text = CDate(lectura("FECHA_NACI"))
            End While
            Conexion.Close()

            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")
            '
            'Mostrar información en las cajas de texto
            'Me.txtFIngreso.Text = CStr(DateAndTime.Now)
            'Me.txtCliente.Text = CStr(ds.Tables(0).Rows.Count + 1)
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            ClientesBd.DataBD.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            ClientesBd.DataBD.DataMember = "Clientess"

            'no permite añadir ni borrar sobre el DataGridView
            ClientesBd.DataBD.AllowUserToAddRows = False
            ClientesBd.DataBD.AllowUserToDeleteRows = False


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Conexion.Close()
        Me.Close()
        PantallaInicio.Show()

    End Sub

    Private Sub Motrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        CheckedListBox1.Items.Clear()
        ClientesBd.Show()

    End Sub

    Public Sub ModificarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtCodCliente.Text = "" Then

            MessageBox.Show("El campo Codigo Cliente esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtNombre.Text = "" Then 'And txtApellido.Text = "" And txtApellido2.Text = "" And txtCodCliente.Text = "" And txtCiudad.Text = "" And txtDNI.Text = "" And txtCodPostal.Text = "" And txtFecha.Text = "" And txtTelefono.Text = "" Then

            MessageBox.Show("El campo nombre esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtApellido.Text = "" Then

            MessageBox.Show("El campo Apellido esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)


        ElseIf txtCodCliente.Text = "" Then

            MessageBox.Show("El campo codigo Cliente esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtApellido2.Text = "" Then

            MessageBox.Show("El campo Apellido2 esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtCiudad.Text = "" Then

            MessageBox.Show("El campo Ciudad esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtDireccion.Text = "" Then

            MessageBox.Show("El campo Direccion esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtDNI.Text = "" Then

            MessageBox.Show("El campo DNI esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtCodPostal.Text = "" Then

            MessageBox.Show("El campo codigo postal esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf mskFecha.Text = "" Then

            MessageBox.Show("El campo fecha esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf txtTelefono.Text = "" Then

            MessageBox.Show("El campo telefono esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        Else

            Dim sSQL As String
            'Dim fecha As Date = Now

            sSQL = "UPDATE Clientes SET NOMBRE = '" & txtNombre.Text & "',APELLIDO1='" & txtApellido.Text & "',APELLIDO2='" & txtApellido2.Text & "',CIUDAD='" & txtCiudad.Text & "',DNI='" & txtDNI.Text & "',DIRECCION='" & txtDireccion.Text & "',COD_POSTAL=" & txtCodPostal.Text & ",FECHA_NAC='" & Format(CType(mskFecha.Text, Date), "yyyy-MM-dd") & "',TELEFONO=" & txtTelefono.Text & "WHERE COD_CLIENTE =" & txtCodCliente.Text & ""
            Dim cmd As New SqlCommand(sSQL, Conexion)
            ' crear comando
            ' Dim cmd As New OleDbCommand(sSQL, Conexion)
            ' abrir conexión
            Conexion.Open()
            'MessageBox.Show("Conectado")
            Dim iResultado As Integer
            ' ejecutar comando
            iResultado = cmd.ExecuteNonQuery()
            ' cerrar conexión
            Conexion.Close()
            MessageBox.Show("Registros modificados:" & iResultado)
            CheckedListBox1.Items.Clear()
            'MessageBox.Show("Desconectado")
            CargarDatos()
        End If




    End Sub

    Private Sub EliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If txtCodCliente.Text = "" Then

            MessageBox.Show("El Codigo del cliente no puede estar vacio al eliminar", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Error)
            'ElseIf If txt

        Else
            Try
                Dim sSQL As String
                sSQL = "DELETE Clientes WHERE COD_CLIENTE = " & txtCodCliente.Text & ""
                '' crear comando
                Dim cmd As New SqlCommand(sSQL, Conexion)

                '' abrir conexión
                Conexion.Open()
                MessageBox.Show("Conectado")
                Dim iResultado As Integer
                '' ejecutar comando

                iResultado = cmd.ExecuteNonQuery()
                '' cerrar conexión
                Conexion.Close()

                Dim lectura As SqlDataReader
                'ListBox.Items.Clear()
                Dim cmd1 As New SqlCommand("SELECT * FROM Clientes", Conexion)
                If Not Conexion Is Nothing Then Conexion.Close()
                Conexion.Open()
                lectura = cmd1.ExecuteReader
                While lectura.Read()

                    CheckedListBox1.Items.Remove(CStr(lectura("COD_CLIENTE")) & " - " & CStr(lectura("NOMBRE")) & " - " & CStr(lectura("DNI")))

                    ConsultaCliente.txtCodCliente.Text = CStr(lectura("COD_CLIENTE"))
                    ConsultaCliente.txtDNI.Text = CStr(lectura("DNI"))
                    ConsultaCliente.txtNombre.Text = CStr(lectura("NOMBRE"))
                    ConsultaCliente.txtApellido.Text = CStr(lectura("APELLIDO1"))
                    ConsultaCliente.txtApellido2.Text = CStr(lectura("APELLIDO2"))
                    ConsultaCliente.txtCiudad.Text = CStr(lectura("CIUDAD"))
                    ConsultaCliente.txtCodPostal.Text = CStr(lectura("COD_POSTAL"))
                    ConsultaCliente.txtDireccion.Text = CStr(lectura("DIRECCION"))
                    ConsultaCliente.txtTelefono.Text = CStr(lectura("TELEFONO"))
                    ConsultaCliente.mskFecha.Text = CDate(lectura("FECHA_NACI"))
                End While

                MessageBox.Show("Registros eliminados:" & iResultado)
                Conexion.Close()
                CheckedListBox1.Items.Clear()
                CargarDatos()

            Catch ex As Exception

                MessageBox.Show("No se puede eliminar un Codigo que tiene Coches", _
           "Aviso", MessageBoxButtons.OK, _
           MessageBoxIcon.Error)

            End Try
        End If

    End Sub

    Private Sub ConsultaCheckedListBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            For i = CheckedListBox1.Items.Count - 1 To 0 Step -1


                If CheckedListBox1.GetItemChecked(i) And CheckedListBox1.GetSelected(i) Then

                    ' CheckedListBox1.Items.Clear()
                    cargarDatosConsulta()
                    ConsultaCliente.Show()

                End If

            Next
        Catch eo As Exception

            MessageBox.Show("El registro no puede estar en blanco")
        End Try


    End Sub

    Private Sub PasarRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            contador = contador + 1
            CheckedListBox1.SelectedIndex = contador
        Catch ex As ArgumentException

            contador = -1

        End Try


    End Sub

    Private Sub AnteriorRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try

            contador1 = contador - 1
            CheckedListBox1.SelectedIndex = contador1
            If contador1 < 0 Then

                contador1 = CheckedListBox1.Items.Count


            End If

        Catch ex As ArgumentException
            contador = -1

        End Try

    End Sub
    Public Sub cargarDatosConsulta()
        Dim TestString As String = CheckedListBox1.Text
        Dim nombre As String = CheckedListBox1.Text
        nombre = Mid(TestString, 1, 2)

        Dim cmd As New SqlCommand("SELECT * FROM Clientes WHERE COD_CLIENTE=" & nombre & "", Conexion)
        Dim lectura As SqlDataReader
        If Not Conexion Is Nothing Then Conexion.Close()
        Conexion.Open()
        lectura = cmd.ExecuteReader
        While lectura.Read()

            ConsultaCliente.txtCodCliente.Text = CStr(lectura("COD_CLIENTE"))
            ConsultaCliente.txtDNI.Text = CStr(lectura("DNI"))
            ConsultaCliente.txtNombre.Text = CStr(lectura("NOMBRE"))
            ConsultaCliente.txtApellido.Text = CStr(lectura("APELLIDO1"))
            ConsultaCliente.txtApellido2.Text = CStr(lectura("APELLIDO2"))
            ConsultaCliente.txtCiudad.Text = CStr(lectura("CIUDAD"))
            ConsultaCliente.txtCodPostal.Text = CStr(lectura("COD_POSTAL"))
            ConsultaCliente.txtDireccion.Text = CStr(lectura("DIRECCION"))
            ConsultaCliente.txtTelefono.Text = CStr(lectura("TELEFONO"))
            ConsultaCliente.mskFecha.Text = CDate(lectura("FECHA_NACI"))


        End While
        Conexion.Close()


    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        Coches.Show()
        Me.Close()


    End Sub
    Private Sub Clientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If



    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged


        contador = CheckedListBox1.SelectedIndex
        contador1 = CheckedListBox1.SelectedIndex

    End Sub

    Private Sub txtCodCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCliente.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtNombre.Focus()
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

        Select Case e.KeyChar
            Case ChrW(13)
                txtApellido2.Focus()
        End Select

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

        Select Case e.KeyChar
            Case ChrW(13)
                txtDNI.Focus()
        End Select

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
                txtTelefono.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress

        Select Case e.KeyChar
            Case ChrW(13)
                txtCodPostal.Focus()
        End Select

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        Select Case e.KeyChar
            Case ChrW(13)
                txtApellido.Focus()
        End Select

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

        Select Case e.KeyChar
            Case ChrW(13)
                txtCiudad.Focus()
        End Select

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

    Private Sub txtCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiudad.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtDireccion.Focus()
        End Select

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

    Private Sub mskFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFecha.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtCodCliente.Focus()
        End Select
    End Sub

    
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtTelefono.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub RecambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecambiosToolStripMenuItem.Click


        Recambio.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Close()
    End Sub

    Friend Function ExisteCodCliente(ByVal CODCLIENTE As Integer) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT COD_CLIENTE FROM CLIENTES WHERE COD_CLIENTE=@COD_CLIENTE"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@COD_CLIENTE", txtCodCliente.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function

    Friend Function ExisteCodDNI(ByVal dni As String) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT DNI FROM CLIENTES WHERE DNI=@DNI"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
End Class