Imports System.Data.SqlClient

Module conexionSql

    'cadena para nectarse a la base de datos por la autenticacion de windows'
    Public conexion As New SqlConnection("Data Source = RICARDO;Initial Catalog=dbUnad;Integrated Security=True")

    'para abrir la conexion a la base de datos'
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    'para cerrar la conexion a la base de datos'
    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module
