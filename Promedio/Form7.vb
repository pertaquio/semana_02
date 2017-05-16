Public Class Form7
    Dim porcientM, porcientF As Double
    Dim cantM, cantF, cantT As Integer
    Dim conteo As Integer

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conteo = 1
        txtnumero.Text = conteo
    End Sub

    Private Sub txtnombres_TextChanged(sender As Object, e As EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        If RadioButton1.Checked Then
            cantM = cantM + 1
        Else
            cantF = cantF + 1
        End If
        lstDatos.Items.Add(txtnumero.Text)
        lstDatos.Items.Add(RadioButton1.Checked)
        cantT = cantT + Val(txtnumero.Text)

        txtnumero.Focus()

        txttm.Text = cantM
        txttmpor.Text = (cantM / conteo) * 100

        txtTF.Text = cantF
        txttfpor.Text = (cantF / conteo) * 100

        txttotalpor.Text = 100%

        conteo = conteo + 1
        txtnumero.Text = conteo
        txtTotal.Text = conteo - 1
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        cantM = 0
        cantF = 0
        cantT = 0
        porcientM = 0
        porcientF = 0
        lstDatos.Items.Clear()
        txtnumero.Text = ""
        txttf.Text = ""
        txttm.Text = ""
        txttotal.Text = ""
        txttfpor.Text = ""
        txttmpor.Text = ""
        txttotalpor.Text = ""
        txtnumero.Focus()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim AvisoSalida As String
        AvisoSalida = MsgBox("Realmente desea salir", MsgBoxStyle.YesNo, "Salir")
        If AvisoSalida = 6 Then
            End
        End If
    End Sub
End Class