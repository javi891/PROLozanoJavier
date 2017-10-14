Imports System.Data.SqlClient
Public Class PantallaInicio

    Private Sub PantallaInicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Seguro que desea salir?", CType(MessageBoxButtons.OKCancel Or MsgBoxStyle.Question, MsgBoxStyle)) = Windows.Forms.DialogResult.OK) Then

            e.Cancel = False
            'Conexion.Close()

        Else

            e.Cancel = True

        End If
    End Sub

    Private Sub PantallaInicio_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked


        Process.Start(".\PROLozanoJavier\CARWORKSHOPMANAGER.chm")

    End Sub


    Private Sub PantallaInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Try


            'Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Taller.accdb"
            Conexion.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\javier\Documents\Visual Studio 2010\Projects\PROLozanoJavier\PROLozanoJavier\Taller2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"


            Conexion.Open()
            MessageBox.Show("Conectado")
        Catch Ex As SqlClient.SqlException
            'si se produce algún error, lo capturamos mediante el objeto de excepciones particular para el proveedor de SQL Server
            'MessageBox.Show("Error al conectar con datos")
        End Try

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click

        Clientes.Show()
        'conectando.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click


        Coches.Show()


    End Sub

    Private Sub CochesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Coches.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RecambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecambiosToolStripMenuItem.Click
        Recambio.Show()
        'conectando.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Averias.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Conexion.Close()
        MessageBox.Show("Desconectado")
        Me.Close()
    End Sub
End Class
