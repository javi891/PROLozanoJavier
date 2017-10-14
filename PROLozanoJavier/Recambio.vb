Imports System.Data.SqlClient

Public Class Recambio
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private iPosicFilaActual As Integer

    Private Sub Recambio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub
    Private Sub Recambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller2DataSet1.Recambios' Puede moverla o quitarla según sea necesario.

        CargarDatos()
        cargarDatosCoches()
        cargarForm()
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
            Dim cmd As New SqlCommand("Select * from Recambios", Conexion)
            '

            da = New SqlDataAdapter
            'Obtenemos el procedimiento almacenado
            da.SelectCommand = cmd
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambioss")

            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataRecambios.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataRecambios.DataMember = "Recambioss"

            'no permite añadir ni borrar sobre el DataGridView
            DataRecambios.AllowUserToAddRows = True
            DataRecambios.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception

        End Try
    End Sub
   
    Public Sub cargarDatosCoches()

        Me.da = New SqlDataAdapter("SELECT * FROM Coches", Conexion)
        ' crear dataset
        Me.ds = New DataSet()
        ' llenar con el adaptador el dataset
        Me.da.Fill(ds, "Coches")

        'indicador del registro a mostrar de la tabla
        Me.iPosicFilaActual = 0
        'cargar columnas del registro en los controles del formulario

    End Sub

    Public Sub cargarForm()

        Try
            Dim Fila As DataRow
            Fila = Me.ds.Tables("Coches").Rows(Me.iPosicFilaActual)

            ' cargar los controles del formulario con los valores de los campos del registro
            txtModeloR.Text = CStr(Fila("MODELO"))
            txtBastidorR.Text = CStr(Fila("NUM_BASTIDOR"))
            txtCodcoche.Text = CStr(Fila("COD_COCHE"))
            txtMatriR.Text = CStr(Fila("MATRICULA"))
            txtMarcR.Text = CStr(Fila("MARCA"))
            Conexion.Close()
        Catch e As Exception


        End Try

    End Sub


    Private Sub btnInsertarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarRe.Click
        Conexion.Close()
        InserccionPiezas.Show()
    End Sub

    Private Sub verlistadoPiezas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Me.Close()
        ListadoPieza.Show()

    End Sub

    Private Sub CalculoCoste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComprasRecambios.Show()
    End Sub

    Private Sub SiguienteRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            If Me.iPosicFilaActual = (Me.ds.Tables("Coches").Rows.Count - 1) Then
                MessageBox.Show("Último registro")
            Else
                ' incrementar el marcador de registro y actualizar 
                ' los controles con los datos del registro actual
                Me.iPosicFilaActual += 1
                Me.cargarForm()
            End If
        Catch exception As NullReferenceException
            MsgBox("Error al borrar", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RegistroAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If Me.iPosicFilaActual = 0 Then
            MessageBox.Show("Primer registro")
        Else
            ' disminuir el marcador de registro y actualizar
            ' los controles con los datos del registro actual
            Me.iPosicFilaActual -= 1
            Me.cargarForm()
        End If
    End Sub

    Private Sub FiltrarporPieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Recambios WHERE COD_PIEZA='" & txtFiltropiez.Text & "'", Conexion)
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
            da.Fill(ds, "Recambios")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambios")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataRecambios.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataRecambios.DataMember = "Recambios"

            'no permite añadir ni borrar sobre el DataGridView
            DataRecambios.AllowUserToAddRows = True
            DataRecambios.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FiltroBusCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Recambios WHERE COD_COCHE='" & txtFiltroCodCoche.Text & "'", Conexion)
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
            da.Fill(ds, "Recambios")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambios")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataRecambios.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataRecambios.DataMember = "Recambios"

            'no permite añadir ni borrar sobre el DataGridView
            DataRecambios.AllowUserToAddRows = True
            DataRecambios.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FiltroNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Recambios WHERE NOMBRE_PIEZA='" & rchBusNomPieza.Text & "'", Conexion)
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
            da.Fill(ds, "Recambios")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambios")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataRecambios.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataRecambios.DataMember = "Recambios"

            'no permite añadir ni borrar sobre el DataGridView
            DataRecambios.AllowUserToAddRows = True
            DataRecambios.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EliminarFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Recambios", Conexion)
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
            da.Fill(ds, "Recambios")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambios")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataRecambios.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataRecambios.DataMember = "Recambios"

            'no permite añadir ni borrar sobre el DataGridView
            DataRecambios.AllowUserToAddRows = True
            DataRecambios.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try


    End Sub

    Private Sub EliminarCocheConrecambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        If txtEliminCodPieza.Text = "" And txtElimCodCoche.Text = "" Then

            MessageBox.Show("Los campos estan vacios")

        ElseIf txtEliminCodPieza.Text = "" Or txtElimCodCoche.Text = "" Then

            MessageBox.Show("el campo codigo de pieza esta vacio o codigo de coche")

        Else
            Dim sSQL As String
            sSQL = "DELETE Recambios WHERE COD_COCHE = " & txtElimCodCoche.Text & " AND COD_PIEZA=" & txtEliminCodPieza.Text & ""
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

            If iResultado <= 0 Then
                MessageBox.Show("No se han encontrado registros que borrar", _
        "Aviso", MessageBoxButtons.OK, _
        MessageBoxIcon.Warning)

            Else
                MessageBox.Show("Registros eliminados:" & iResultado)
            End If
            CargarDatos()

        End If

        


    End Sub

    Private Sub txtElimCodCoche_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtElimCodCoche.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtEliminCodPieza.Focus()
            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub

    Private Sub txtEliminCodPieza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEliminCodPieza.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                txtElimCodCoche.Focus()
            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select
    End Sub


    Private Sub txtFiltropiez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltropiez.KeyPress
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

    Private Sub txtFiltroCodCoche_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroCodCoche.KeyPress

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

    Private Sub motrarcoches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Coches.Show()
        Me.Close()

    End Sub
End Class