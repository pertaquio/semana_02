Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtnombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombres.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txtedad.Focus()
        End Select
    End Sub

    Private Sub TxtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtedad.KeyPress
        Dim edad As Integer
        edad = Val(Me.txtedad.Text)
        Select Case e.KeyChar
            Case Chr(13)
                If edad < 18 Or edad > 26 Then
                    MsgBox("Edad no contemplada")
                    Me.txtedad.Text = ""
                    txtedad.Focus()
                Else
                    txtnota.Focus()
                End If
        End Select
    End Sub


    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        Dim edad, nota, pension, dcto, neto As Integer
        Dim condi As String
        edad = Val(Me.txtedad.Text)
        Select Case edad
            Case 18 To 20
                condi = "pobre"
                pension = 400
            Case 21 To 23
                condi = "Media"
                pension = 600
            Case 24 To 26
                condi = "Alta"
                pension = 1000
        End Select
        nota = Val(Me.txtnota.Text)
        Select Case nota
            Case 15 To 18
                dcto = pension * 0.08
            Case 13 To 14
                dcto = pension * 0.05
            Case 11 To 12
                dcto = pension * 0.01
            Case 10 To 0
                dcto = 0
                MsgBox("no hay descuento")
        End Select
        neto = pension - dcto
        txtcondi.Text = condi
        txtpension.Text = Str(pension)
        txtdcto.Text = Str(dcto)
        txtneto.Text = Str(neto)
        btnnuevo.Focus()
    End Sub

    Private Sub TxtNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnota.KeyPress
        Dim nota As Integer
        nota = Val(Me.txtnota.Text)
        Select Case e.KeyChar
            Case Chr(13)
                If nota > 18 Or nota < 11 Then
                    MsgBox("Nota fuera de rango")
                    Me.txtnota.Text = ""
                    txtnota.Focus()
                Else
                    btncalcular.Focus()
                End If
        End Select
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Me.txtnombres.Text = ""
        Me.txtedad.Text = ""
        Me.txtnota.Text = ""
        Me.TxtCondi.Text = ""
        Me.TxtPension.Text = ""
        Me.TxtDcto.Text = ""
        Me.txtneto.Text = ""
        Me.txtnombres.Focus()
    End Sub

    Private Sub txtnota_TextChanged(sender As Object, e As EventArgs) Handles txtnota.TextChanged

    End Sub
End Class