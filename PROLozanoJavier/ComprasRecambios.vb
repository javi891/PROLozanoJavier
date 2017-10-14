Imports System.Data.SqlClient

Public Class ComprasRecambios
    Private iPosicFilaActual As Integer
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private Sub ComprasRecambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller2DataSet1.Recambios' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'Taller2DataSet.Recambios' Puede moverla o quitarla según sea necesario.


        ''Dim v1, v2 As Decimal

        ' '' Recorremos las filas
        ''For Each Fila As DataGridViewRow In DataCompras.Rows

        ''    ' comprobamos que los valores de las celdas sean numeros y acepten decimales
        ''    If Decimal.TryParse(CStr(Fila.Cells(0).Value), v1) = True AndAlso
        ''        Decimal.TryParse(CStr(Fila.Cells(1).Value), v2) = True Then
        ''        Fila.Cells(2).Value = v1 + v2
        ''    Else
        ''        Fila.Cells(2).Value = ""
        ''    End If


        'Next
       

        cargarDatos()
        CargarDatosFilas()
    End Sub
    Public Sub cargarDatos()
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
            '

            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambioss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCompras.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCompras.DataMember = "Recambioss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCompras.AllowUserToAddRows = True
            DataCompras.AllowUserToDeleteRows = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub CargarDatosFilas()
        ' obtener un objeto con la fila actual
        'Dim Fila As DataRow
        ' Fila = Me.ds.Tables("Recambios").Rows(Me.iPosicFilaActual)
        'Fila = Me.ds.Tables("Coches").Rows(Me.iPosicFilaActual)

        ' cargar los controles del formulario con los valores de los campos del registro
        Dim cmd As New SqlCommand("Select * from Recambios,Coches", Conexion)
        Dim lectura As SqlDataReader
        If Not Conexion Is Nothing Then Conexion.Close()
        Conexion.Open()
        lectura = cmd.ExecuteReader
        While lectura.Read()

            'txtCodCche.Text = CStr(lectura("COD_COCHE")) & Environment.NewLine & CStr(lectura("COD_PIEZA")) & Environment.NewLine & CStr(lectura("NOMBRE_PIEZA")) & Environment.NewLine & CStr(lectura("MODELO")) & Environment.NewLine & CStr(lectura("MARCA")) & Environment.NewLine & CStr(lectura("CANTIDAD_PIEZA")) & Environment.NewLine & CStr(lectura("PRECIO_PIEZA"))


        End While

    End Sub

    Private Sub DataCompras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataCompras.DoubleClick


        Try
            txtCantiP.Text = DataCompras.Item(4, DataCompras.CurrentRow.Index).Value
            txtPrecioUni.Text = DataCompras.Item(3, DataCompras.CurrentRow.Index).Value
            txtConcepto.Text = DataCompras.Item(1, DataCompras.CurrentRow.Index).Value
            Dim IVA As Double

            IVA = txtPrecioUni.Text * 21 / 100

            txtPrecioIva.Text = txtPrecioUni.Text + IVA

            txtTotal.Text = txtPrecioIva.Text * txtCantiP.Text

            'txtPrecioIva.Text = CStr(Format(CDbl(Val(txtPrecioIva.Text)), " € "))
            'txtTotal.Text = CStr(Format(CDbl(Val(txtTotal.Text)), "##,##0.00" & " € "))
            'txtPrecioUni.Text = CStr(Format(CDbl(Val(txtPrecioUni.Text)), " € "))

        Catch EXCEPTION As Exception

            MessageBox.Show("Error no puede ser nulo la fila seleccionada")

        End Try

    End Sub

    Private Sub CerrarFormulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataCompras_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataCompras.SelectionChanged

        Try
            Dim resul As Decimal = DataCompras.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDecimal(x.Cells("Preciopieza").Value))
            Dim resul2 As Decimal = DataCompras.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDecimal(x.Cells("Cantidadpieza").Value))
            txtTotalpiez.Text = resul.ToString() * resul2.ToString

            'txtTotal.Text = txtPrecioIva.Text * txtCantiP.Text
            'Dim resul2 As Decimal = DataCompras.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDecimal(x.Cells("Preciopieza").Value))
            'txtTotal.Text = resul2.ToString()

        Catch eo As Exception

        End Try

    End Sub

    Private Sub MostrarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If txtComCodCoche.Text = "" Then

                MessageBox.Show("No puede estar el campo codigo de coche vacio")

            Else

                Dim Sql As String
                Sql = "SELECT * FROM Recambios WHERE COD_COCHE = " & txtComCodCoche.Text & ""
                Dim da As New SqlDataAdapter(Sql, Conexion)
                Dim ds As New DataSet
                '
                '***************************
                'Rellenar el DataSet con el contenido de la órden SELECT
                da.Fill(ds, "Remcambios")
                Dim dt As DataTable
                dt = ds.Tables(0)
                '
                '*********************************
                '**** Información ****************
                'Propiedades de dt: Columns (columnas), Rows (filas)
                'Me.lblInformacion.Text = _
                '"Nº de filas del resultado de la Select es: " & _
                'dt.Rows.Count & " y de columnas " & dt.Columns.Count
                ''
                ''*********************************
                ''**** Vaciar cajas de texto ******
                'Me.txtCliente.Text = ""
                'Me.txtFIngreso.Text = ""
                'Me.txtNombre.Text = ""
                '
                '*********************************
                '**** Visualización datos ********
                '
                '*********** DataGridView ********
                'enlazar dataset con el DdataGridView.
                'en DataSource se asigna el DataTable, si especificasemos DataSet, tendríamos que especificar la propiedad DataMembers,indicando el nombre de la tabla del dataset que mostrará el DataGridView
                '
                'DataSource, Indicamos el origen de datos
                'Me.DataGridView1.DataSource = dt
                ''no permite añadir ni borrar sobre el DataGridView
                'Me.DataGridView1.AllowUserToAddRows = False
                'Me.DataGridView1.AllowUserToDeleteRows = False
                'Me.DataGridView1.CancelEdit()
                ''
                '*********** Un sólo TextBox ********
                ' Declaramos la propiedad Row para recorrer
                ' las filas contenidas en el DataSet
                Dim Row As DataRow
                ' Recorremos todas las filas y las tratamos
                Compra.txtContenido.Text = ""
                For Each Row In ds.Tables(0).Rows
                    Compra.txtContenido.Text += _
                    "" & Environment.NewLine & "  CODIGO PIEZA: " & CStr(Row(0)) & vbTab & _
                    "" & Environment.NewLine & "  NOMBRE DE PIEZA: " & CStr(Row("NOMBRE_PIEZA")) & vbTab & _
                    Environment.NewLine & "  PRECIO: " & CStr(Row(3)) & " €" & Environment.NewLine & "  CANTIDAD: " & CStr(Row(4)) & Environment.NewLine & "===================================="
                Next
                Compra.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
        Dim resul As Decimal = DataCompras.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDecimal(x.Cells("Preciopieza").Value))
        Dim resul2 As Decimal = DataCompras.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDecimal(x.Cells("Cantidadpieza").Value))

        Dim IVA As Decimal


        Compra.txtTotal.Text = resul.ToString() * resul2.ToString()

        IVA = CDec(txtTotal.Text * 21 / 100)

        Compra.txtTotal.Text = CDec(txtTotal.Text) + IVA
        '+ CStr(IVA)
        ' Compra.txtTotal.Text = CStr(Format(CDbl(Val(Compra.txtTotal.Text)), "##,##0.00" & " € "))

    End Sub
   
    Private Sub FiltrarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            'CheckedListBox1.Items.Clear()
            Dim cmd As New SqlCommand("Select * from Recambios WHERE COD_COCHE='" & txtComCodCoche.Text & "'", Conexion)
            '

            'Dim cmd As New SqlCommand(sSQL, Conexion)
            '*******************************
            '
            'da = New SqlDataAdapter
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
            DataCompras.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCompras.DataMember = "Recambios"

            'no permite añadir ni borrar sobre el DataGridView
            DataCompras.AllowUserToAddRows = True
            DataCompras.AllowUserToDeleteRows = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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

            ds = New DataSet()
            '

            'utilizar el adaptador para llenar el dataset.
            da.Fill(ds, "Recambioss")
            '
            'ConsultaCoches.Text = CStr(DateAndTime.Now)
            'DataCoche.Text = CStr(ds.Tables(0).Rows.Count + 1)
            '
            'enlazar dataset con el DdataGridView;
            'en DataSource se asigna el dataset,
            DataCompras.DataSource = ds
            'DataMember, indicar el nombre de la tabla del dataset que mostrará el datagrid
            DataCompras.DataMember = "Recambioss"

            'no permite añadir ni borrar sobre el DataGridView
            DataCompras.AllowUserToAddRows = True
            DataCompras.AllowUserToDeleteRows = True
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub cargarclientesCochesCompra()


        Dim cmd As New SqlCommand("SELECT * FROM Clientes,Coches WHERE COD_COCHE=" & txtComCodCoche.Text & "AND CLIENTES.COD_CLIENTE=COCHES.COD_CLIENTE", Conexion)
        Dim lectura As SqlDataReader
        If Not Conexion Is Nothing Then Conexion.Close()
        Conexion.Open()
        lectura = cmd.ExecuteReader

        While lectura.Read()

            Compra.txtComCliente.Text = CStr(lectura("COD_CLIENTE"))
            Compra.txtComDNI.Text = CStr(lectura("DNI"))
            Compra.txtComNombre.Text = CStr(lectura("NOMBRE"))
            Compra.txtComTelefono.Text = CStr(lectura("TELEFONO"))
            Compra.txtComDireccion.Text = CStr(lectura("DIRECCION"))
            Compra.txtComCodPostal.Text = CStr(lectura("COD_POSTAL"))
            Compra.mskComFecha.Text = CDate(lectura("FECHA_NACI"))
            Compra.txtComCiudad.Text = CStr(lectura("CIUDAD"))
            Compra.txtComCodcoche.Text = CStr(lectura("COD_COCHE"))
            Compra.txtComMotor.Text = CStr(lectura("MOTOR"))
            Compra.txtComModelo.Text = CStr(lectura("MODELO"))
            Compra.txtComMarca.Text = CStr(lectura("MARCA"))
            Compra.txtComKilometros.Text = CStr(lectura("KILOMETROS"))
            Compra.txtComBastidor.Text = CStr(lectura("NUM_BASTIDOR"))
            Compra.txtComApellido.Text = CStr(lectura("APELLIDO1"))
            Compra.txtComApellido2.Text = CStr(lectura("APELLIDO2"))
            Compra.txtComMatricula.Text = CStr(lectura("MATRICULA"))
            
        End While
        Conexion.Close()



    End Sub

    Private Sub txtComCodCoche_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComCodCoche.KeyPress
         Select Case e.KeyChar
            Case ChrW(13)

            Case ChrW(8), ChrW(44) 'el 8 borra blackspace y el 44 es la coma para los decimales
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case ChrW(46) 'el 46 es el punto que lo sustituye por la coma, para que la funciona "CDec" haga bien la conversion
                e.KeyChar = ChrW(44)
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select


    End Sub
End Class