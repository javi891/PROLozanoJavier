Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Coches
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private iPosicFilaActual As Integer

    Private Sub Coches_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub

    Private Sub Coches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '
            'ruta = ruta.Substring(0, Len(ruta) - 9) & "Taller2.mdf"
            ' pasar la cadena de conexión
            'Conexion.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\javier\Documents\Visual Studio 2010\Projects\PROLozanoJavier\PROLozanoJavier\Taller2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            ' Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Taller.mdb"


        Dim Marcas() As String = New String() _
   {"Seat", "Renault", "Citroen", "Opel", "Volkswagen", "Skoda", "Ford", "Kia", "Hyundai", "Honda", "Toyota", "Mitsubishi", "Audi", "BMW", "Mercedes", "Nissan", "Chevrolet", "Volvo", "Porsche", "Lexus", "Subaru", "Dodge", "Fiat", "Dacia", "Lancia"}

            CargarDatos()
        'CargarCoche()
            cargarDatosClient2()
            CargarDatosClientes()

            cbxMarca.Items.AddRange(Marcas)
            pbmodelos.BackgroundImageLayout = ImageLayout.Stretch


        'Catch ex As Exception
        ' si se produce algún error, lo capturamos mediante el objeto de excepciones particular para el proveedor de SQL Server
        'MessageBox.Show("Error al conectar con datos")
        'End Try





    End Sub

    Private Sub InserccionCoches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click


        Dim existe As Boolean = ExisteMatricula(txtMatricula.Text)
        
        If Me.txtCodcoche.Text = "" Then

            MessageBox.Show("El campo codigo de coche esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)


        ElseIf (existe) Then
            MessageBox.Show("Ya existe la matricula.")
            ' Abandonamos el procedimiento.
            Return


        ElseIf (existe) Then
            MessageBox.Show("Ya existe el numero de bastidor.")
            ' Abandonamos el procedimiento.
            Return
        ElseIf txtMatricula.Text = "" Then

            MessageBox.Show("El campo matricula esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

        ElseIf cbxMarca.Text = "" Then

        MessageBox.Show("El campo marca esta vacio", _
    "Aviso", MessageBoxButtons.OK, _
    MessageBoxIcon.Warning)

        ElseIf txtModelo.Text = "" Then

        MessageBox.Show("El campo modelo esta vacio", _
    "Aviso", MessageBoxButtons.OK, _
    MessageBoxIcon.Warning)

        ElseIf txtBastidor.Text = "" Then

            MessageBox.Show("El campo bastidor esta vacio", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)
        ElseIf Len(txtBastidor.Text) < 17 Then

            MessageBox.Show("El campo de bastidor no puede ser menor de 17 digitos", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)
        Else

            Dim existe3 As Boolean = ExisteMatricula(txtMatricula.Text)

            If (existe3) Then
                MessageBox.Show("Ya existe la matricula.")
                ' Abandonamos el procedimiento.
                Return
            End If
            Dim existe4 As Boolean = ExisteBastidor(txtBastidor.Text)
            If (existe4) Then
                MessageBox.Show("Ya existe el Numero de bastidor.")
                ' Abandonamos el procedimiento.
                Return
            End If
            Dim existe5 As Boolean = ExisteCodigoCoche(txtCodcoche.Text)
            If (existe5) Then
                MessageBox.Show("Ya existe el Codigo de Coche.")
                ' Abandonamos el procedimiento.
                Return
            End If



            Dim sqlInsert2 As String

            sqlInsert2 = "INSERT INTO COCHES (COD_COCHE,NOM_CONDUCTOR,NUM_BASTIDOR,MARCA,COD_CLIENTE,MODELO,MOTOR,MATRICULA,KILOMETROS,IMAGEN)VALUES(" & txtCodcoche.Text & ",'" & txtNomCon.Text & "','" & txtBastidor.Text & "','" & cbxMarca.Text & "'," & txtCodClient.Text & ",'" & txtModelo.Text & "','" & txtMotor.Text & "','" & txtMatricula.Text & "'," & txtKilometros.Text & ",'" & pbmodelos.ImageLocation & "')"
            '" & Me.txtNomCoch.Text & "'" & "," & "'" & Me.txtNomCon.Text & "'" & "," & Me.txtBast.Text & "," & "'" & Me.txtMarcCoche.Text & "'" & "," & Me.txtCodClient.Text & "," & "'" & Me.txtModelo.Text & "'" & "," & "'" & Me.txtTip.Text & "'" & "," & Me.txtCodcoche.Text & " 
            '(" & Me.txtCliente.Text & "," & "'" & Me.txtNombre.Text & "'" & "," & "'" & Me.txtFIngreso.Text & "'" & ")"
            Dim Comando As New SqlCommand(sqlInsert2, Conexion)

            Dim iResultado As Integer

            'Conexion.Open()

            MessageBox.Show("Conectado")

            iResultado = Comando.ExecuteNonQuery()

            MessageBox.Show("Registros añadidos:" & iResultado)

            Conexion.Close()
            MessageBox.Show("Desconectado")
            CargarDatos()

            txtCodcoche.Text = ""
            txtBastidor.Text = ""
            txtModelo.Text = ""
            txtMotor.Text = ""
            txtMatricula.Text = ""
            txtKilometros.Text = ""
        End If

    End Sub

    Public Sub CargarDatos()

        '**** Uso de DataAdapter y SqlCommand *******
        '** sin uso de DataTable ********************
        'crear adaptador
        'da = New OleDbDataAdapter("SELECT * FROM Coches", Conexion)
        'Declaramos el DataSet dónde volcaremos los datos

        Try
            '
            'Inserta datos en el checkedListBox de la base de datos
            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches", Conexion)
            '
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            ds = New DataSet()
            '
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub ModificarCoches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If txtCodcoche.Text = "" Then
            MessageBox.Show("El campo codigo de coche esta vacio")

        Else
            FormularioCoche.Show()

        End If



    End Sub

    Private Sub EliminarCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        '
        Try
            If txtCodcoche.Text = "" Then
                MessageBox.Show("Error al eliminar el campo codigo de coche esta vacio ")
            Else

                Dim sSQL As String
                sSQL = "DELETE Coches WHERE COD_COCHE = " & txtCodcoche.Text & ""
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
                CargarDatos()
                If iResultado <= 0 Then
                    MessageBox.Show("No se han encontrado registros que borrar", _
                   "Aviso", MessageBoxButtons.OK, _
                   MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Registros eliminados:" & iResultado)

                End If


            End If

        Catch ew As Exception


            MessageBox.Show("El coche tiene recambios y no se puede borrar", _
       "Aviso", MessageBoxButtons.OK, _
       MessageBoxIcon.Error)
        End Try



        ''MessageBox.Show("Desconectado")
        'Catch Ex As Exception
        'MessageBox.Show("El campo Codigo Coche esta vacio", _
        '"Aviso", MessageBoxButtons.OK, _
        'MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub MostrarRecambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Clientes.Close()
        MenuOpciones.Show()
        Me.Close()

    End Sub

    Private Sub FiltrarPorMatricula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE MATRICULA='" & txtFiltroMatri.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try
        '
    End Sub

    Private Sub BuscarPorBastidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE NUM_BASTIDOR='" & txtFiltroBasti.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FiltrarPorKilometros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE KILOMETROS='" & txtFiltroKilom.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FiltrarCodigoCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE COD_COCHE='" & txtFiltroCod.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FiltradodeModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE MODELO='" & txtFiltroMode.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub FiltroBusquedaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Coches WHERE MARCA='" & txtFiltroMarca.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            cmd = Nothing
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Clientess")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Cochesss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCoche.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCoche.DataMember = "Cochesss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCoche.AllowUserToAddRows = True
            DataCoche.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try


    End Sub
    Public Sub cargarDatosClient2()
        Try
            Me.da = New SqlDataAdapter("SELECT * FROM Clientes", Conexion)
            ' crear dataset
            Me.ds = New DataSet()
            ' llenar con el adaptador el dataset
            Me.da.Fill(ds, "Clientes")

            'indicador del registro a mostrar de la tabla
            Me.iPosicFilaActual = 0
            'cargar columnas del registro en los controles del formulario
            Me.CargarDatosClientes()
        Catch Es As Exception

        End Try

    End Sub
    Public Sub CargarDatosClientes()
        ' obtener un objeto con la fila actual
        Try
            Dim Fila As DataRow
            Fila = Me.ds.Tables("Clientes").Rows(Me.iPosicFilaActual)

            ' cargar los controles del formulario con los valores de los campos del registro
            txtCodClient.Text = CStr(Fila("COD_CLIENTE"))
            txtNomCon.Text = CStr(Fila("NOMBRE")) & " " & CStr(Fila("APELLIDO1"))
        Catch e As Exception

        End Try



    End Sub


    Private Sub EliminarFiltroBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click




        'CheckedListBox1.Items.Clear()
        Dim cmd As New SqlCommand("Select * from Coches", Conexion)
        '

        'Dim cmd As New SqlCommand(sSQL, Conexion)
        '*******************************
        '
        da = New SqlDataAdapter
        'Obtenemos el procedimiento almacenado
        da.SelectCommand = cmd
        cmd = Nothing
        'Declaramos el DataSet dónde volcaremos los datos
        ds = New DataSet()
        'utilizar el adaptador para llenar el dataset.
        da.Fill(ds, "Clientess")

        '**** Uso de DataAdapter y SqlCommand *******
        '** sin uso de DataTable ********************
        'crear adaptador
        'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
        'Declaramos el DataSet dónde volcaremos los datos
        ds = New DataSet()
        '
        'Inserta datos en el checkedListBox de la base de datos
        'utilizar el adaptador para llenar el dataset.
        da.Fill(ds, "Cochesss")
        '
        'ConsultaCoches.Text = CStr(DateAndTime.Now)
        'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
        '
        'enlazar dataset con el DdataGridView;
        'en DataSource se asigna el dataset,
        DataCoche.DataSource = ds
        'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
        DataCoche.DataMember = "Cochesss"

        'no permite añadir ni borrar sobre el DataGridView
        DataCoche.AllowUserToAddRows = True
        DataCoche.AllowUserToDeleteRows = True


        Conexion.Close()

    End Sub

    Private Sub txtCodClient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodClient.KeyPress

        Select Case e.KeyChar
            Case ChrW(13)
                txtNomCon.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select

    End Sub

    Private Sub txtNomCon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomCon.KeyPress

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

        Me.txtNomCon.Text = Trim(Replace(Me.txtNomCon.Text, " ", ""))
        txtNomCon.Select(txtNomCon.Text.Length, 0)

    End Sub

    Private Sub txtCodcoche_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodcoche.KeyPress

        
        Select Case e.KeyChar
            Case ChrW(13)
                txtMatricula.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select

    End Sub


    Private Sub txtKilometros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilometros.KeyPress


        Select Case e.KeyChar
            Case ChrW(13)
                txtCodcoche.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select



    End Sub


    Private Sub btnInserIm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserIm.Click

        


        '// Se crea el OpenFileDialog
       Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    pbmodelos.ImageLocation = .FileName
                End If
            End With

        End Using

    End Sub


    Private Sub SiguienteCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If Me.iPosicFilaActual = (Me.ds.Tables("Clientes").Rows.Count - 1) Then
                MessageBox.Show("Último registro")
            Else
                ' incrementar el marcador de registro y actualizar 
                ' los controles con los datos del registro actual
                Me.iPosicFilaActual += 1
                Me.CargarDatosClientes()
            End If
        Catch exception As Exception

        End Try
    End Sub

    Private Sub AnteriorCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.iPosicFilaActual = 0 Then
            MessageBox.Show("Primer registro")
        Else
            ' disminuir el marcador de registro y actualizar
            ' los controles con los datos del registro actual
            Me.iPosicFilaActual -= 1
            Me.CargarDatosClientes()
        End If
    End Sub

    Private Sub mskmatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case ChrW(13)
                txtModelo.Focus()
        End Select
    End Sub

    

   
    Private Sub txtBastidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBastidor.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtMotor.Focus()
        End Select


        txtBastidor.Text = UCase(txtBastidor.Text)


    End Sub

    Private Sub txtModelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModelo.KeyPress

        Select Case e.KeyChar
            Case ChrW(13)
                txtBastidor.Focus()
        End Select

    End Sub

    Private Sub txtMotor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotor.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtKilometros.Focus()
        End Select
        txtMotor.Text = UCase(txtMotor.Text)
    End Sub

    Private Sub txtFiltroKilom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroKilom.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtCodcoche.Focus()
            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtFiltroCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroCod.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtCodcoche.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtFiltroMarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroMarca.KeyPress

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

        Me.txtFiltroMarca.Text = Trim(Replace(Me.txtFiltroMarca.Text, " ", ""))
        txtFiltroMarca.Select(txtFiltroMarca.Text.Length, 0)

    End Sub

    Private Sub CochesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CochesToolStripMenuItem.Click

        Clientes.Show()
        Me.Close()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtMatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatricula.KeyPress
        If txtMatricula.TextLength < 4 Then
            Select Case e.KeyChar
                Case ChrW(8) '8 borrar
                Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
                Case Else 'todo lo demas no se escribe
                    e.KeyChar = ChrW(0)
            End Select
        ElseIf txtMatricula.TextLength = 4 Then

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
        End If

    End Sub
    Friend Function ExisteBastidor(ByVal bastidor As String) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT NUM_BASTIDOR FROM COCHES WHERE NUM_BASTIDOR=@NUM_BASTIDOR"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@NUM_BASTIDOR", txtBastidor.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
    Friend Function ExisteCodigoCoche(ByVal bastidor As String) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT COD_COCHE FROM COCHES WHERE COD_COCHE=@COD_COCHE"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@COD_COCHE", txtCodcoche.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
    Friend Function ExisteMatricula(ByVal bastidor As String) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT MATRICULA FROM COCHES WHERE MATRICULA=@MATRICULA"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@MATRICULA", txtMatricula.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
End Class