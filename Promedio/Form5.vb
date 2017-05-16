Public Class Form5

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim su, ne, im As Integer
        su = Val(Me.txtsueldo.Text)
        im = (su / 10)
        ne = su - im

        If su <= 1800 Then
            im = (su / 10)
            ne = su - im
        Else
            im = 0
            ne = su
        End If

        Me.txtneto.Text = Str(ne)
        Me.txtimpuesto.Text = Str(im)


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim AvisoSalida As String
        AvisoSalida = MsgBox("Realmente desea salir", MsgBoxStyle.YesNo, "Salir")
        If AvisoSalida = 6 Then
            End
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        txtsueldo.Clear()
        txtneto.Clear()
        txtimpuesto.Clear()
        txtsueldo.Focus()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class