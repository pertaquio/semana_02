Public Class Form2

    Private Sub btnconvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        Dim a As Integer
        Dim x, z As Single
        a = Val(Me.txtingresar.Text)
        x = (1.609)
        z = (a * x)
        Me.txtresultado.Text = Str(z)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Me.txtingresar.Text = ""
        Me.txtresultado.Text = ""
        Me.txtingresar.Focus()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
