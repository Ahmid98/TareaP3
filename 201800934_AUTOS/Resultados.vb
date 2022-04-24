Module Resultados

    Public Const tipo1 = 500
    Public Const tipo2 = 400
    Public Const tipo3 = 300
    Public Const tipo4 = 200
    Public pos As Byte
    Public index As Byte = 0
    Public numero1(7) As Byte
    Public placa1(7) As Integer
    Public tipo_carro1(7) As String
    Public kilo_inicial1(7) As Double
    Public kilo_final1(7) As Double
    Public cobro_base1(7) As Double
    Public pago_final1(7) As Double

    Function Calcular() As Double
        Dim total As Double

        If index <= 6 Then
            placa1(index) = Val(Form1.txt_placa.Text)

            If Form1.rb_tipo1.Checked Then
                tipo_carro1(index) = "Tipo 1"
                cobro_base1(index) = tipo1
                total = tipo1
            ElseIf Form1.rb_tipo2.Checked Then
                tipo_carro1(index) = "Tipo 2"
                cobro_base1(index) = tipo2
                total = tipo2
            ElseIf Form1.rb_tipo3.Checked Then
                tipo_carro1(index) = "Tipo 3"
                cobro_base1(index) = tipo3
                total = tipo3
            ElseIf Form1.rb_tipo4.Checked Then
                tipo_carro1(index) = "Tipo 4"
                cobro_base1(index) = tipo4
                total = tipo4
            End If
            numero1(index) = index + 1
            kilo_inicial1(index) = Val(Form1.txt_kiloI.Text)
            kilo_final1(index) = Val(Form1.txt_kiloF.Text)

            If (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) <= 50 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 3
            ElseIf (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) <= 70 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 4
            ElseIf (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) > 70 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 5
            End If
        Else
            MsgBox("Ya se llenaron los registros..")
        End If
        Return total
    End Function

    Function Consultar(placa As Integer) As Byte
        Dim posicion As Byte
        Dim existe As Boolean = False
        For i = 0 To 6
            If placa1(i) = placa Then
                pos = i
                posicion = i
                existe = True
                Form1.txt_placa.Text = placa1(i)
                Form1.txt_kiloI.Text = kilo_inicial1(i)
                Form1.txt_kiloF.Text = kilo_final1(i)

                Select Case tipo_carro1(i)
                    Case "Tipo 1"
                        Form1.rb_tipo1.Checked = True
                    Case "Tipo 2"
                        Form1.rb_tipo2.Checked = True
                    Case "Tipo 3"
                        Form1.rb_tipo3.Checked = True
                    Case "Tipo 4"
                        Form1.rb_tipo4.Checked = True
                End Select

            End If
        Next i

        If existe = True Then
            MsgBox("Registro encontrado correctamente..")
        Else
            MsgBox("Registro no encontrado..")
        End If

        Return posicion
    End Function

    Sub Eliminar(placa12 As Integer)
        Dim posicion As Byte
        Dim pos_aux As Byte

        For i = 0 To 6
            If placa1(i) = placa12 Then
                posicion = i
                placa1(i) = Nothing
                tipo_carro1(i) = Nothing
                kilo_inicial1(i) = Nothing
                kilo_final1(i) = Nothing
                cobro_base1(i) = Nothing
                pago_final1(i) = Nothing
            End If
        Next i

        While (posicion <= 5)



            placa1(posicion) = placa1(posicion + 1)
                tipo_carro1(posicion) = tipo_carro1(posicion + 1)
                kilo_inicial1(posicion) = kilo_inicial1(posicion + 1)
                kilo_final1(posicion) = kilo_final1(posicion + 1)
                cobro_base1(posicion) = cobro_base1(posicion + 1)
                pago_final1(posicion) = pago_final1(posicion + 1)
                posicion += 1

        End While




        MsgBox("Registro eliminado correctamente..")

    End Sub

    Function Modificar(posicion As Byte)
        Dim total As Double


        placa1(posicion) = Val(Form1.txt_placa.Text)

        If Form1.rb_tipo1.Checked Then
            tipo_carro1(posicion) = "Tipo 1"
            cobro_base1(posicion) = tipo1
            total = tipo1
            ElseIf Form1.rb_tipo2.Checked Then
            tipo_carro1(posicion) = "Tipo 2"
            cobro_base1(posicion) = tipo2
            total = tipo2
            ElseIf Form1.rb_tipo3.Checked Then
            tipo_carro1(posicion) = "Tipo 3"
            cobro_base1(posicion) = tipo3
            total = tipo3
            ElseIf Form1.rb_tipo4.Checked Then
            tipo_carro1(posicion) = "Tipo 4"
            cobro_base1(posicion) = tipo4
            total = tipo4

        End If
        numero1(posicion) = posicion + 1
        kilo_inicial1(posicion) = Val(Form1.txt_kiloI.Text)
        kilo_final1(posicion) = Val(Form1.txt_kiloF.Text)

        If (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) <= 50 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 3
            ElseIf (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) <= 70 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 4
            ElseIf (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) > 70 Then
                total += (Form1.txt_kiloF.Text - Form1.txt_kiloI.Text) * 5
            End If

        pago_final1(posicion) = total

        MsgBox("Registro eliminado correctamente..")
        Return 0
    End Function

End Module
