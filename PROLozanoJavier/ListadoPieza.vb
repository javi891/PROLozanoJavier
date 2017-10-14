Imports System.Data.SqlClient

Public Class ListadoPieza
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private iPosicFilaActual As Integer
    Private WithEvents bs As New BindingSource
    Private bEdit As Boolean

    Private Sub ListadoPieza_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bEdit Then
            'preguntar si se desea guardar  
            If (MsgBox( _
                    "Guardar cambios ?", _
                     MsgBoxStyle.YesNo, _
                    "guardar")) = MsgBoxResult.Yes Then

                Actualizar(False)
            End If
        End If
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub
    Private Sub ListadoPieza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            With DataListaPiezas
                ' alternar color de filas  
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
                .DefaultCellStyle.BackColor = Color.Beige
                ' Establecer el origen de datos para el DataGridview  
                .DataSource = bs
            End With

            'btnEliminarReg.Text = "ELIMINAR RECAMBIOS"

            'btnModificarRe.Text = "MODIFICAR RECAMBIOS"


            'cargar_registros("Select * From Pieza Order by COD_PIEZA", DataListaPiezas)

            CargarDatosLista()
            comboCoches()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cargar_registros( _
        ByVal sql As String, _
        ByVal dv As DataGridView)



        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string  
            da = New SqlDataAdapter(sql, Conexion)

            Dim SqlCommandBuilder As New SqlCommandBuilder(da)

            ' llenar el DataTable  
            Dim dt As New DataTable()

            da.Fill(dt)

            ' Enlazar el BindingSource con el datatable anterior  
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            bs.DataSource = dt
            

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                .FirstDisplayedScrollingRowIndex = bs.Position
            End With

            bEdit = False

            cargarDatosPiezas()
            CargarDatos()
        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub


    Private Sub AñadirAcoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If cbxCodC.Text = "" Then

                MessageBox.Show("Error no hay ningun codigo de cliente asignado para la insercción")
            ElseIf txtCanti.Text = 0 Or txtPrecioP.Text = 0 Then

                MessageBox.Show("La cantidad a insertar no puede ser 0")

            ElseIf txtCanti.Text = 0 And txtPrecioP.Text = 0 Then

                MessageBox.Show("Cantidad y precio no pueden ser igual a 0")


            Else

                Dim sqlInsert2 As String

                'DataListaPiezas(row = DataListaPiezas.CurrentRow)
                Replace(txtPrecioP.Text, ",", ".")
                    sqlInsert2 = "INSERT INTO RECAMBIOS (COD_PIEZA,NOMBRE_PIEZA,COD_COCHE,PRECIO_PIEZA,CANTIDAD_PIEZA)VALUES(" & txtCodP.Text & ",'" & richNom.Text & "'," & cbxCodC.Text & "," & Double.Parse(Val(txtPrecioP.Text)) & "," & txtCanti.Text & ")"
                    '" & Me.txtNomCoch.Text & "'" & "," & "'" & Me.txtNomCon.Text & "'" & "," & Me.txtBast.Text & "," & "'" & Me.txtMarcCoche.Text & "'" & "," & Me.txtCodClient.Text & "," & "'" & Me.txtModelo.Text & "'" & "," & "'" & Me.txtTip.Text & "'" & "," & Me.txtCodcoche.Text & " 
                    '(" & Me.txtCliente.Text & "," & "'" & Me.txtNombre.Text & "'" & "," & "'" & Me.txtFIngreso.Text & "'" & ")"


                    Dim Comando As New SqlCommand(sqlInsert2, Conexion)


                    Dim iResultado As Integer
                    MessageBox.Show("Conectado")

                    Conexion.Open()

                    iResultado = Comando.ExecuteNonQuery()
                    RestarCantidad()
                    If iResultado <= 0 Then
                        MessageBox.Show("Error no se a podido insertar el registro", _
                "Aviso", MessageBoxButtons.OK, _
                MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Registros añadidos:" & iResultado)

                        Conexion.Close()
                        MessageBox.Show("Desconectado")
                    End If
                    Recambio.Show()
                End If
        Catch es As Exception

            MessageBox.Show("El registro ya existe no se puede duplicar", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)

        End Try

    End Sub
    Public Sub RestarCantidad()

        Dim sSQL As String
        Dim fecha As Date = Now

        sSQL = "UPDATE Pieza SET CANTIDAD=CANTIDAD-" & txtCanti.Text & " WHERE COD_PIEZA=" & txtCodP.Text & ""

        ' crear comando
        Dim cmd As New SqlCommand(sSQL, Conexion)
        ' abrir conexió
        'MessageBox.Show("Conectado")
        Dim iResultado As Integer
        ' ejecutar comando
        iResultado = cmd.ExecuteNonQuery()
        ' cerrar conexión
        Conexion.Close()
        MessageBox.Show("Registros modificados:" & iResultado)
        Conexion.Close()
        'For Each row As DataGridViewRow In DataListaPiezas.Rows

        '    row.Cells("Cantidad").Value = CDec(row.Cells("Cantidad").Value) - CDec(txtCanti.Text)

        'Next


    End Sub



    Public Sub cargarDatosPiezas()
        Me.da = New SqlDataAdapter("SELECT * FROM Pieza", Conexion)
        ' crear dataset
        Me.ds = New DataSet()
        ' llenar con el adaptador el dataset
        Me.da.Fill(ds, "Pieza")

        'indicador del registro a mostrar de la tabla
        Me.iPosicFilaActual = 0
        'cargar columnas del registro en los controles del formulario
        Me.CargarDatos()

    End Sub
    Private Sub CargarDatos()
        ' obtener un objeto con la fila actual
        Try
            Dim Fila As DataRow
            Fila = Me.ds.Tables("Pieza").Rows(Me.iPosicFilaActual)

            ' cargar los controles del formulario con los valores de los campos del registro
            txtCodP.Text = CStr(Fila("COD_PIEZA"))

            

            txtPrecioP.Text = CStr(Fila("PRECIO"))
            'txtPrecioP.Text = CStr(Format(CDbl(Val(txtPrecioP.Text)), "##,##0.00" & " € "))
            txtCanti.Text = CStr(Fila("CANTIDAD"))
            richNom.Text = CStr(Fila("NOMBRE_RECAMBIO"))
        Catch e As Exception

        End Try


        ' mostrar la posición actual del registro y el número total del registros
    End Sub

    Private Sub SiguientePieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If Me.iPosicFilaActual = (Me.ds.Tables("Pieza").Rows.Count - 1) Then
                MessageBox.Show("Último registro")
            Else
                ' incrementar el marcador de registro y actualizar 
                ' los controles con los datos del registro actual
                Me.iPosicFilaActual += 1
                Me.CargarDatos()
            End If
        Catch a As Exception

        End Try

    End Sub

    Private Sub PiezaAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If Me.iPosicFilaActual = 0 Then
            MessageBox.Show("Primer registro")
        Else
            ' disminuir el marcador de registro y actualizar
            ' los controles con los datos del registro actual
            Me.iPosicFilaActual -= 1
            Me.CargarDatos()
        End If
    End Sub

    Private Sub BusquedaPorCodPieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Pieza WHERE COD_PIEZA='" & txtbusPieza.Text & "'", Conexion)
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
            da.Fill(ds, "Pieza")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Piezass")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataListaPiezas.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataListaPiezas.DataMember = "Piezass"

            'no permite añadir ni borrar sobre el DataGridView
            DataListaPiezas.AllowUserToAddRows = True
            DataListaPiezas.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Pieza", Conexion)
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
            da.Fill(ds, "Pieza")

            '**** Uso de DataAdapter y SqlCommand *******
            '** sin uso de DataTable ********************
            'crear adaptador
            'da = New OleDbDataAdapter("SELECT COD_CLIENTE,NUM_BASTIDOR,COD_COCHE,MARCA,MODELO FROM Coches", Conexion)
            'Declaramos el DataSet dónde volcaremos los datos
            ds = New DataSet()
            '
            'Inserta datos en el checkedListBox de la base de datos
            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Piezass")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataListaPiezas.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataListaPiezas.DataMember = "Piezass"

            'no permite añadir ni borrar sobre el DataGridView
            DataListaPiezas.AllowUserToAddRows = True
            DataListaPiezas.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CargarDatosLista()

        '
        'Inserta datos en el checkedListBox de la base de datos
        'CheckedListBox1.Items.Clear()
        Dim cmd As New SqlCommand("Select * from Pieza", Conexion)
        '
        da = New SqlDataAdapter
        'Obtenemos el procedimiento almacenado
        da.SelectCommand = cmd
        cmd = Nothing
        'Declaramos el DataSet dónde volcaremos los datos
        ds = New DataSet()
        ''utilizar el adaptador para llenar el dataset.
        da.Fill(ds, "Pieza")
        '
        'ConsultaCoches.Text = CStr(DateAndTime.Now)
        'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
        '
        'enlazar dataset con el DdataGridView;
        'en DataSource se asigna el dataset,
        DataListaPiezas.DataSource = ds
        'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
        DataListaPiezas.DataMember = "Pieza"

        'no permite añadir ni borrar sobre el DataGridView
        DataListaPiezas.AllowUserToAddRows = True
        DataListaPiezas.AllowUserToDeleteRows = True

        cargarDatosPiezas()
        CargarDatos()
        Conexion.Close()

    End Sub

    Private Sub DataListaPiezas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListaPiezas.CellContentClick

        Select Case e.ColumnIndex
            Case 4 ' Es la columna Modificar

                ' Recorremos las cuatro primeras celdas de la
                ' fila actual para obtener sus valores.
                '
                For n As Int32 = 0 To 3
                    Dim o As Object = _
                    (DataListaPiezas.Rows(e.RowIndex).Cells(n).Value)

                    MessageBox.Show(CStr(o))

                Next

            Case 5 ' Es la columna Borrar

                ' Eliminamos la fila que contiene la celda actual, siempre
                ' y cuando no se trate de una nueva fila.
                '
                If Not DataListaPiezas.CurrentRow.IsNewRow Then
                    DataListaPiezas.Rows.Remove(DataListaPiezas.CurrentRow)
                End If

            Case Else ' Se ha hecho clic en cualquier otra columna
                Return

        End Select

    End Sub

    'For Each row As DataGridViewRow In DataListaPiezas.SelectedRows
    '      DataListaPiezas.Rows.Remove(row)
    '  Next


    Private Sub EliminarRecambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not bs.Current Is Nothing Then
            ' eliminar  
            bs.RemoveCurrent()

            'Guardar los cambios y recargar  
            Actualizar()
        Else
            MsgBox("No hay un registro actual para eliminar", _
                   MsgBoxStyle.Exclamation, _
                   "Eliminar")
        End If

    End Sub

    Private Sub btnModificarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarRe.Click
        Actualizar()
        FormModificarRecambio.Show()
    End Sub

    Private Sub Actualizar(Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios  

        If Not bs.DataSource Is Nothing Then
            da.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
                cargar_registros("Select * From Pieza Order by COD_PIEZA", DataListaPiezas)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit( _
       ByVal sender As Object, _
       ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
           Handles DataListaPiezas.CellEndEdit

        bEdit = True
    End Sub


    Public Sub comboCoches()
        Dim cmd As New SqlCommand("Select COD_COCHE from Coches", Conexion)
        Dim lectura As SqlDataReader
        If Not Conexion Is Nothing Then Conexion.Close()
        Conexion.Open()
        lectura = cmd.ExecuteReader
        While lectura.Read()

            cbxCodC.Items.Add(CStr(lectura("COD_COCHE")))


        End While
        Conexion.Close()
    End Sub

  
    Private Sub txtbusPieza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbusPieza.KeyPress
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

    Private Sub txtPrecioP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioP.KeyPress
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
            txtPrecioP.Text += "."c
            txtPrecioP.SelectionStart = txtPrecioP.Text.Length
        End If
    End Sub

End Class