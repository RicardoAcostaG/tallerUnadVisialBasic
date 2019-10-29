Imports System.Data.SqlClient


Public Class usuarios
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Try

            Dim cmd As New SqlCommand
            abrir()

            cmd = New SqlCommand("Estudiantes_Insertar", conexion)
            cmd.CommandType = 4

            'pasar los datos de la vista de asuario por parametros a la base de datos'
            cmd.Parameters.AddWithValue("@numeroIdentificacin", txtNumeroIdentificacion)
            cmd.Parameters.AddWithValue("@tipoDocumento", txtTipoDucumento)
            cmd.Parameters.AddWithValue("@nombre", txtNombre)
            cmd.Parameters.AddWithValue("@apellido", txtApellido)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion)
            cmd.Parameters.AddWithValue("@IdCiudad", txtCiudad)
            cmd.Parameters.AddWithValue("@IdDepartamentos", txtDepartamento)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono)
            cmd.Parameters.AddWithValue("@fechaNacimiento", txtFechaNacimiento)
            cmd.Parameters.AddWithValue("@lugarNacimiento", txtLugarNacimiento)
            cmd.Parameters.AddWithValue("@usuario", txtUsuario)
            cmd.Parameters.AddWithValue("@contraseña", txtContraseña)

            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()

            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try


    End Sub

    Sub Mostrar()

        Dim datosTable As New DataTable
        Dim datosExtraidos As SqlDataAdapter

        Try

            abrir()
            datosExtraidos = New SqlDataAdapter("Estudiantes_Consultar", conexion)
            datosExtraidos.Fill(datosTable)
            dataListado.DataSource = datosTable
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub txtFechaNacimiento_Click(sender As Object, e As EventArgs) Handles txtFechaNacimiento.Click

        txtFechaNacimiento.Text = ""
        txtFechaNacimiento.Focus()

    End Sub

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
        Mostrar()
    End Sub
End Class