Public Class Resultados

    Dim combinacionGanadora(5) As Integer
    Dim reintegroGanador As Integer
    Dim combinationUser(5) As Integer
    Dim reintegrousuario As Integer
    Dim aciertos As Integer
    Dim refund As Boolean


    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelresultado.Controls.Clear()
        panelresultadoganador.Controls.Clear()

        combinacionGanadora = Form1.combinacionGanadora
        reintegroGanador = Form1.reintegro.Text.ToString
        combinationUser = Form1.combinacionUsuario
        reintegrousuario = Form1.num8


        fillData(panelresultado, combinationUser, reintegrousuario)
        fillData(panelresultadoganador, combinacionGanadora, reintegroGanador)

        For i = 0 To combinationUser.Length - 1
            If combinationUser.Contains(combinacionGanadora(i)) Then
                aciertos += 1
            End If
        Next

        If reintegrousuario = reintegroGanador Then
            refund = True
        End If

        labelAciertos.Text = labelAciertos.Text & aciertos

        If refund Then
            labeldevolucion.Text = "Por acertar el reintegro, tienes la devolución del dinero!"
        End If

        aciertos = 0
        Erase combinationUser

        Erase combinacionGanadora




    End Sub



    Private Sub fillData(panel As Panel, combination() As Integer, refund As Integer)

        Dim left As Integer = 30

        For i = 0 To 5
            Dim label As New Label
            label.Text = combination(i)
            label.Left = left
            label.Font = New Font(Me.Font, FontStyle.Bold)
            label.Top = 20
            label.AutoSize = True
            panel.Controls.Add(label)
            left = left + 60
        Next

        Dim labelDevolucion As New Label
        labelDevolucion.Left = left
        labelDevolucion.Top = 10
        labelDevolucion.AutoSize = True
        labelDevolucion.Font = New Font(Me.Font, FontStyle.Bold)
        labelDevolucion.TextAlign = ContentAlignment.MiddleCenter
        labelDevolucion.Text = "Reintegro: " & vbCrLf & refund
        panel.Controls.Add(labelDevolucion)

    End Sub


End Class
