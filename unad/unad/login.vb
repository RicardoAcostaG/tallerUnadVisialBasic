Public Class login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click

        txtUsuario.Text = ""
        txtUsuario.Focus()

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click

        txtPass.Text = ""
        txtPass.Focus()

    End Sub
End Class
