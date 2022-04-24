Public Class Form1


    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Resultados.Consultar(txt_consultaplaca.Text)
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        Resultados.Modificar(pos)
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Resultados.Eliminar(txt_consultaplaca.Text)
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click

        pago_final1(index) = System.Math.Round(Resultados.Calcular(), 2)

        index += 1

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        tabla.Rows.Clear()
        Dim i As Byte = 0

        While (i <= 6)

            If (placa1(i) <> Nothing) Then
                tabla.Rows.Add(numero1(i), placa1(i), tipo_carro1(i), kilo_inicial1(i), kilo_final1(i), cobro_base1(i), pago_final1(i))
            Else
                Exit While
            End If
            i = i + 1
        End While
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        tabla.Rows.Clear()

        For i = 0 To 6
            placa1(i) = Nothing
            tipo_carro1(i) = Nothing
            kilo_inicial1(i) = Nothing
            kilo_final1(i) = Nothing
            cobro_base1(i) = Nothing
            pago_final1(i) = Nothing
        Next i

        index = 0
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub
End Class
