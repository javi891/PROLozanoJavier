Imports System.Data.SqlClient

Public Class Averias
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private iPosicFilaActual As Integer

    Private Sub Averias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub
    Private Sub Averias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller2DataSet2.Averias' Puede moverla o quitarla según sea necesario.


        'CheckedListBox1.Items.Clear()
       

        'cargar columnas del registro en los controles del formulario

        datosAveria()
        Try
            Dim sql As String
            sql = "SELECT * FROM Pieza"
            '**************************************
            ' crear DataReader
            Dim MiDataReader As SqlDataReader

            Dim dt As New DataTable
            '
            'Dos formas:
            'Dim Comando As New SqlCommand(sql, MiConexion)
            Dim Comando As SqlCommand
            ' Establecemos la Conexión con la base de datos
            Comando = New SqlCommand(sql, Conexion)
            '
            ' Abrimos la Conexión
            Conexion.Open()
            'MessageBox.Show("Conectado")
            '
            ' Ejecutamos la sentencia SQL, obtener DataReader
            MiDataReader = Comando.ExecuteReader()
            '
            ' Si hay datos los mostramos
            If MiDataReader.HasRows Then
                ' Cargamos los resultados en el objeto DataTable
                ' Load, nos permite cargar un DataReader para volcarlo a continuación dentro de un control 
                dt.Load(MiDataReader, LoadOption.OverwriteChanges)
                ' Volcamos los datos en el control TextBox
                BindingSource1.DataSource = dt
                BindingNavigator1.BindingSource = BindingSource1
                'TextBox1.DataBindings.Add(New Binding("Text", BindingSource1, "IdCliente"))
                'enlazar los datos con el objeto (textBox)
                txtAveriaCodp.DataBindings.Add("Text", BindingSource1, "COD_PIEZA")
                richTextBoxnPieza.DataBindings.Add(New Binding("Text", BindingSource1, "NOMBRE_RECAMBIO"))
            Else
                MessageBox.Show("No hay datos de Averias")
            End If
            Comando = Nothing
            ' cerrar conexión
            Conexion.Close()
            'MessageBox.Show("Desconectado")

        Catch oExcep As SqlClient.SqlException
            'si se produce algún error, lo capturamos mediante el objeto de excepciones particular para el proveedor de SQL Server
            MessageBox.Show("Error al conectar con datos")
        End Try

    End Sub

    Private Sub Reparacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        ListadoPieza.Show()
    End Sub
    Public Sub datosAveria()

        Dim cmd As New SqlCommand("Select * from Averias", Conexion)
        '
        da = New SqlDataAdapter
        'Obtenemos el procedimiento almacenado
        da.SelectCommand = cmd
        cmd = Nothing
        'Declaramos el DataSet dónde volcaremos los datos
        ds = New DataSet()
        'utilizar el adaptador para llenar el dataset.
        da.Fill(ds, "Averias")
        '
        'ConsultaCoches.Text = CStr(DateAndTime.Now)
        'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
        '
        'enlazar dataset con el DdataGridView;
        'en DataSource se asigna el dataset,
        DataAverias.DataSource = ds
        'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
        DataAverias.DataMember = "Averias"

        'no permite añadir ni borrar sobre el DataGridView
        DataAverias.AllowUserToAddRows = True
        DataAverias.AllowUserToDeleteRows = True
        Conexion.Close()

    End Sub

    Private Sub InsertarNuevaAveria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtAveriaCod.Text = "" Then

            MessageBox.Show("El campo nombre de averia esta vacio", _
           "Aviso", MessageBoxButtons.OK, _
           MessageBoxIcon.Warning)

        ElseIf richTextBoxnAveria.Text = "" Then
            MessageBox.Show("El campo codigo de averia esta vacio", _
           "Aviso", MessageBoxButtons.OK, _
           MessageBoxIcon.Warning)
        Else

            Dim sqlInsert2 As String
            Try

                Dim existe5 As Boolean = ExisteCodAveria(txtAveriaCod.Text)
                If (existe5) Then
                    MessageBox.Show("Ya existe el Codigo de Averia.")
                    ' Abandonamos el procedimiento.
                    Return
                End If
                Dim existe6 As Boolean = ExisteNombrAveria(richTextBoxnAveria.Text)
                If (existe6) Then
                    MessageBox.Show("Ya existe el nombre de averia")
                    ' Abandonamos el procedimiento.
                    Return
                End If
                sqlInsert2 = "INSERT INTO AVERIAS (COD_AVERIA,NOMBRE_AVERIA,COD_PIEZA,NOMBRE_PIEZA)VALUES(" & txtAveriaCod.Text & ",'" & richTextBoxnAveria.Text & "'," & txtAveriaCodp.Text & ",'" & richTextBoxnPieza.Text & "')"
                Dim Comando As New SqlCommand(sqlInsert2, Conexion)


                Dim iResultado As Integer
                MessageBox.Show("Conectado")
                If (Comando.Connection.State = ConnectionState.Closed) Then
                    Comando.Connection.Open()
                End If


                iResultado = Comando.ExecuteNonQuery()

                MessageBox.Show("Registros añadidos:" & iResultado)

                Conexion.Close()
                MessageBox.Show("Desconectado")
            Catch Exception As Exception
                'MessageBox.Show("Error al insertar")
            End Try
            datosAveria()
        End If

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtAveriaCod.Text = "" Then

            MessageBox.Show("El campo codigo de averia esta vacio", _
           "Aviso", MessageBoxButtons.OK, _
           MessageBoxIcon.Warning)

        Else
            Dim sSQL As String
            sSQL = "DELETE Averias WHERE COD_AVERIA = " & txtAveriaCod.Text & ""
            '' crear comando
            Dim cmd As New SqlCommand(sSQL, Conexion)

            '' abrir conexión
            Conexion.Open()
            MessageBox.Show("Conectado")
            Dim iResultado As Integer
            '' ejecutar comando

            iResultado = cmd.ExecuteNonQuery()
            '' cerrar conexión
            If iResultado <= 0 Then
                MessageBox.Show("No existe ningún registro a borrar", _
           "Aviso", MessageBoxButtons.OK, _
           MessageBoxIcon.Warning)

            Else
                MessageBox.Show("Registros borrados:" & iResultado)
                Conexion.Close()
            End If
            
        End If
        datosAveria()
        

    End Sub

    Private Sub salirdeaverias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub txtAveriaCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAveriaCod.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtEliminCodPieza.Focus()
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub


    Private Sub txtAveriaCodp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAveriaCodp.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                'txtEliminCodPieza.Focus()
            Case ChrW(8) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub
    Friend Function ExisteCodAveria(ByVal codAveria As Integer) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT COD_AVERIA FROM AVERIAS WHERE COD_AVERIA=@COD_AVERIA"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@COD_AVERIA", txtAveriaCod.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function


    Friend Function ExisteNombrAveria(ByVal NOMBRE As sTRING) As Boolean


        Dim cmd As SqlCommand = Conexion.CreateCommand()

        ' Consultamos la tabla de Matriculas para recuperar el registro donde
        ' el campo Matricula coincida con el número de matricula especificado.
        '
        cmd.CommandText = "SELECT NOMBRE_AVERIA FROM AVERIAS WHERE NOMBRE_AVERIA=@NOMBRE_AVERIA"

        ' Añadimos el único parámetro de entrada requerido.
        '
        cmd.Parameters.AddWithValue("@NOMBRE_AVERIA", richTextBoxnAveria.Text)
        If (cmd.Connection.State = ConnectionState.Closed) Then
            cmd.Connection.Open()
        End If


        Dim n As Object = cmd.ExecuteScalar()
        ' Comprobamos si existe o no alguna fila.
        Return (n IsNot Nothing)

        Conexion.Close()
    End Function
End Class