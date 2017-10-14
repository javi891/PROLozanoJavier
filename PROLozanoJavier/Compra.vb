Imports System.Data.SqlClient

Public Class Compra

    Private Sub Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        ComprasRecambios.cargarclientesCochesCompra()

    End Sub
    
   
    Private Sub Comprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result2 As DialogResult = MessageBox.Show("Quiere realizar la compra?", _
            "Compra", _
            MessageBoxButtons.YesNoCancel, _
            MessageBoxIcon.Question)
        If (result2 = Windows.Forms.DialogResult.Yes) Then
            Dim sSQL As String
            sSQL = "DELETE Recambios WHERE COD_COCHE = " & ComprasRecambios.txtComCodCoche.Text & ""
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
            MessageBox.Show("Compra Realizada: " & iResultado)
            Me.Close()
        Else

        End If

       
        'CargarDatos()

    End Sub

    Private Sub Cancelarventana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class