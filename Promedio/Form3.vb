Public Class Form3

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnconvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        Dim i, n As Integer
        Dim imp, s, par As Integer
        n = Val(Me.txtingresar.Text)
        For i = 1 To n
            imp = i Mod 2
            If imp = 0 Then
                par = 0
            Else
                s = s + i
            End If
        Next
        Me.txtresultado.Text = Str(s)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Me.txtingresar.Text = ""
        Me.txtresultado.Text = ""
        Me.txtingresar.Focus()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class