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
            cmd.Parameters.AddWithValue("@numeroIdentificacin", txtNumeroIdentificacion.Text)
            cmd.Parameters.AddWithValue("@tipoDocumento", txtTipoDucumento.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@IdCiudad", cmbCiudad.SelectedValue)
            cmd.Parameters.AddWithValue("@IdDepartamentos", cmbDepartamento.SelectedValue)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@fechaNacimiento", txtFechaNacimiento.Text)
            cmd.Parameters.AddWithValue("@lugarNacimiento", txtLugarNacimiento.Text)
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text)

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

        'TODO: esta línea de código carga datos en la tabla 'DbUnadDataSet5.Departamentos' Puede moverla o quitarla según sea necesario.
        Me.DepartamentosTableAdapter.Fill(Me.DbUnadDataSet5.Departamentos)
        'TODO: esta línea de código carga datos en la tabla 'DbUnadDataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
        Me.CiudadesTableAdapter.Fill(Me.DbUnadDataSet4.Ciudades)

    End Sub
End Class