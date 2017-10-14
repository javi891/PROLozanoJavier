Imports System.Data.SqlClient

Public Class FormModificarRecambio

    Private Sub btnModificarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarRe.Click

        If txtModifCant.Text = "" Or txtModifprecio.Text = "" Then
            MessageBox.Show("Un campo o otro esta vacio")
        ElseIf txtModifprecio.Text = "" And txtModifCant.Text = "" Then

            MessageBox.Show("Los dos campos estan vacios")
        ElseIf txtModifprecio.Text = 0 Or txtModifCant.Text = 0 Then
            MessageBox.Show("El precio o la cantidad no puede ser 0")

        Else
            Dim sSQL As String
            sSQL = "UPDATE Pieza SET PRECIO = " & txtModifprecio.Text & ",CANTIDAD=" & txtModifCant.Text & "WHERE COD_PIEZA=" & txtModCodpieza.Text & ""

            ' crear comando
            Dim cmd As New SqlCommand(sSQL, Conexion)
            ' abrir conexión
            Conexion.Open()
            'MessageBox.Show("Conectado")
            Dim iResultado As Integer
            ' ejecutar comando
            iResultado = cmd.ExecuteNonQuery()
            ' cerrar conexión
            Conexion.Close()
            MessageBox.Show("Registros modificados:" & iResultado)
            ListadoPieza.cargarDatosPiezas()
        End If



        


    End Sub

    Private Sub btnEliminarReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarReg.Click
        Try
            If txtModCodpieza.Text = "" Then

                MessageBox.Show("El campo de Codigo pieza esta vacio")
            Else
                Dim sSQL As String
                sSQL = "DELETE Pieza WHERE COD_PIEZA = " & txtModCodpieza.Text & ""
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
                MessageBox.Show("Registros eliminados:" & iResultado)
            End If
        Catch ed As Exception
            MessageBox.Show("No se a podido eliminar tiene otra relacion con otra tabla", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Warning)
        End Try
        ListadoPieza.CargarDatosLista()


    End Sub

    Private Sub modificarCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If txtModifCant.Text = "" Then

            MessageBox.Show("El campo de cantidad esta vacio")
        ElseIf txtModifCant.Text = 0 Then
            MessageBox.Show("la cantidad no puede ser 0")
        Else
            Dim sSQL As String

            sSQL = "UPDATE Pieza SET CANTIDAD= " & txtModifCant.Text & "WHERE COD_PIEZA=" & txtModCodpieza.Text & ""

            ' crear comando
            Dim cmd As New SqlCommand(sSQL, Conexion)
            ' abrir conexión
            Conexion.Open()
            'MessageBox.Show("Conectado")
            Dim iResultado As Integer
            ' ejecutar comando
            iResultado = cmd.ExecuteNonQuery()
            ' cerrar conexión
            Conexion.Close()
            MessageBox.Show("Registros modificados:" & iResultado)
        End If
        

    End Sub

    Private Sub modificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        

        If txtModifprecio.Text = "" Then

            MessageBox.Show("El campo de cantidad esta vacio")
        ElseIf txtModifprecio.Text <= 0 Then
            MessageBox.Show("El precio no puede ser menor que 0 o igual")
        Else
            Dim sSQL As String

            sSQL = "UPDATE Pieza SET PRECIO= " & txtModifprecio.Text & "WHERE COD_PIEZA=" & txtModCodpieza.Text & ""

            ' crear comando
            Dim cmd As New SqlCommand(sSQL, Conexion)
            ' abrir conexión
            Conexion.Open()
            'MessageBox.Show("Conectado")
            Dim iResultado As Integer
            ' ejecutar comando
            iResultado = cmd.ExecuteNonQuery()
            ' cerrar conexión
            Conexion.Close()
            MessageBox.Show("Registros modificados:" & iResultado)
        End If
        ListadoPieza.CargarDatosLista()


    End Sub

    Private Sub FormModificarRecambio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub

    Private Sub txtModCodpieza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModCodpieza.KeyPress
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

    Private Sub txtModifCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModifCant.KeyPress
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

    Private Sub txtModifprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModifprecio.KeyPress
        Select Case e.KeyChar
            Case ChrW(8)
            Case ChrW(48) To ChrW(57) 'los numeros del 1 al 0
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select

        If e.KeyChar = "," Then
            e.Handled = True
            txtModifprecio.Text += "."c
            txtModifprecio.SelectionStart = txtModifprecio.Text.Length
        End If
    End Sub

    Private Sub FormModificarRecambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class