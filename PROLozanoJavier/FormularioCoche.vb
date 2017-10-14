Imports System.Data.SqlClient

Public Class FormularioCoche

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If Me.txtCodClient.Text = "" Then

            MessageBox.Show("Falta el codigo de coche para realizar la modificación")

        Else
            Dim sSQL As String
            sSQL = "UPDATE Coches SET NOM_CONDUCTOR = '" & txtNomCon.Text & "',MARCA='" & cbxMarca.Text & "',MODELO='" & txtModelo.Text & "',NUM_BASTIDOR='" & txtBastidor.Text & "',MOTOR='" & txtMotor.Text & "',KILOMETROS= " & txtKilometros.Text & " ,MATRICULA='" & txtMatricula.Text & "',IMAGEN='" & pbmodelos.ImageLocation & "' WHERE COD_CLIENTE =" & txtCodClient.Text & " AND COD_COCHE=" & txtCodcoche.Text & ""

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
            'MessageBox.Show("Desconectado")
            Coches.CargarDatos()
        End If
        Me.Close()

    End Sub

    Public Sub cargarDatosCoches()
        'Dim TestString As String = txtCodClient.Text
        ' Returns "Hello".
        'Dim nombre As String = txtCodClient.Text
        'nombre = Mid(TestString, 1, 2)
        
            Dim cmd As New SqlCommand("SELECT * FROM Coches WHERE COD_COCHE=" & Coches.txtCodcoche.Text & "", Conexion)
            Dim lectura As SqlDataReader
            If Not Conexion Is Nothing Then Conexion.Close()
            Conexion.Open()
            lectura = cmd.ExecuteReader
            While lectura.Read()

                txtCodClient.Text = CStr(lectura("COD_CLIENTE"))
                txtNomCon.Text = CStr(lectura("NOM_CONDUCTOR"))
                txtBastidor.Text = CStr(lectura("NUM_BASTIDOR"))
                cbxMarca.Text = CStr(lectura("MARCA"))
                txtCodcoche.Text = CStr(lectura("COD_COCHE"))
                txtModelo.Text = CStr(lectura("MODELO"))
            txtMatricula.Text = CStr(lectura("MATRICULA"))
                txtKilometros.Text = CStr(lectura("KILOMETROS"))
            txtMotor.Text = CStr(lectura("MOTOR"))
            pbmodelos.ImageLocation = CStr(lectura("IMAGEN"))

            End While
            Conexion.Close()

    End Sub

    Private Sub FormularioCoche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Marcas() As String = New String() _
  {"Seat", "Renault", "Citroen", "Opel", "Volkswagen", "Skoda", "Ford", "Kia", "Hyundai", "Honda", "Toyota", "Mitsubishi", "Audi", "BMW", "Mercedes", "Nissan", "Chevrolet", "Volvo", "Porsche", "Lexus", "Subaru", "Dodge", "Fiat", "Dacia", "Lancia"}
        cbxMarca.Items.AddRange(Marcas)
       
            cargarDatosCoches()



    End Sub

    Private Sub txtCodcoche_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodcoche.TextChanged

    End Sub

    Private Sub btnInserIm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserIm.Click
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
            Case Else
                e.KeyChar = ChrW(0)
                MessageBox.Show("Formato introducido incorrecto")
        End Select



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
End Class