Imports System.Data.SqlClient

Module Module1
    Public contador As Integer = 0
    Public contador1 As Integer = 0

    'Public Conexion As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Public Conexion As New SqlConnection
    'Public ruta As String = Application.StartupPath
    ' crear el objeto de conexión
    Public da As SqlDataAdapter
    'Declaramos el DataSet dónde volcaremos los datos
    Public ds As DataSet
    Public CargarDatos()





End Module
