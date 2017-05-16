Public Class Form6

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lstdatos.Items.Add(txtcodigo.Text)
        lstdatos.Items.Add(txtapellidos.Text)
        lstdatos.Items.Add(txtnombres.Text)
        lstdatos.Items.Add(txtdireccion.Text)
        lstdatos.Items.Add(txttelefono)
        lstdatos.Items.Add(txtEmail)

        lstdatos.Items.Add(txtcodigo.Text + ", " + txtapellidos.Text + ", " + txtnombres.Text + ", " + txtdireccion.Text + ", " + txttelefono.Text + ", " + txtEmail.Text)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text = ""
        txtapellidos.Text = ""
        txtnombres.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtEmail.Text = ""
        txtcodigo.Focus()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim AvisoSalida As String
        AvisoSalida = MsgBox("Realmente desea salir", MsgBoxStyle.YesNo, "Salir")
        If AvisoSalida = 6 Then
            End
        End If
    End Sub
End Class