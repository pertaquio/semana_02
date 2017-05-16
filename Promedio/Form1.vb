Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, hora, min As Integer
        a = Val(Me.TextBox1.Text) 'captura el contenido del cuadro de texto y lo almacena en la variable A
        hora = a \ 60 'la variable HORA contendra e residuo de la división
        min = a - (hora * 60) 'Contendra los minutos sobrantes
        Me.TextBox2.Text = Str(hora) & " horas y " & min & " minutos"
        'val() convierte caracteres a valor numerico
        'str() convierte numeros a caracteres
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim AvisoSalida As String
        AvisoSalida = MsgBox("Realmente desea salir", MsgBoxStyle.YesNo, "Salir")
        If AvisoSalida = 6 Then
            End
        End If

    End Sub
End Class