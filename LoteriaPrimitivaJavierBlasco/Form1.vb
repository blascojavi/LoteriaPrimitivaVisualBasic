Public Class Form1
    'generamos los arrays
    Public combinacionGanadora(6) As Integer
    Public combinacionUsuario(5) As Integer
    'un random
    Dim RandomNumber As New Random
    'variables
    Public num1, num2, num3, num4, num5, num6, num7, num8 As Integer
    Dim numerosArray As String
    Dim num As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos los resultados del sorteo al arrancar
        mostrar_resultados_sorteo()

        'generamos el aleatorio del reintegro  de la apuesta a rellenar a mano'
        num8 = RandomNumber.Next(0, 9)
        reintegro2.Text = num8

        'declaramos las variables necesarias para realizar el bucle for e imprimir los checkboxes'
        Dim iteracion As Integer = 1
        Dim arriba As Integer = 0
        Dim izquierda As Integer = 50


        'Bucle for donde le indicamos 7 filas y 7 columnas y genera 49 checkBox en tiempo de ejecucion'
        For i = 0 To 6
            'columnas'
            For j = 0 To 6
                'filas'
                Dim casilla As New CheckBox 'declaramos el elemento checkbox '
                casilla.Text = iteracion
                iteracion = iteracion + 1
                casilla.Top = arriba
                casilla.Left = izquierda
                izquierda = izquierda + 60
                casilla.Width = 50
                casilla.Parent = checkboxPanel
                Console.WriteLine(casilla.Text)

            Next j
            'Indicamos que en cada iteración cambien de posicion'
            izquierda = +50
            arriba = arriba + 40

        Next i

    End Sub
    Private Function mostrar_resultados_sorteo()
        'array de números de lotería


        'generamos los seis números aleatorios
        For i = 0 To combinacionGanadora.Length - 1
            Dim numeroprueba As Integer
            numeroprueba = RandomNumber.Next(1, 50)
            'Comprobamos que no se haya introducido el valor ya generado
            For j = 0 To combinacionGanadora.Length - 1
                If numeroprueba = combinacionGanadora(j) Then
                    numeroprueba = RandomNumber.Next(1, 50)
                End If
            Next
            'grabamos el número en el array
            combinacionGanadora(i) = numeroprueba
        Next
        'los ordenamos por orden ascendente
        Array.Sort(combinacionGanadora)

        'Generamos el reintegro del sorteo
        num7 = RandomNumber.Next(0, 9)

        'imprimimos en cada textbox el valor'
        'Queda pendiente hacer un for para recorrerlo y meter automaticamente los datos en los textBox

        numero1.Text = combinacionGanadora(0)
        numero2.Text = combinacionGanadora(1)
        numero3.Text = combinacionGanadora(2)
        numero4.Text = combinacionGanadora(3)
        numero5.Text = combinacionGanadora(4)
        numero6.Text = combinacionGanadora(5)
        reintegro.Text = num7
        num7 = combinacionGanadora(6)

        'los ponemos en el array de la combinación, es un doble paso, hay que ajustarlo
        'combinacionGanadora(0) = combinacionGanadora(0)
        'combinacionGanadora(1) = combinacionGanadora(1)ºº
        'combinacionGanadora(2) = combinacionGanadora(2)
        'combinacionGanadora(3) = combinacionGanadora(3)
        'combinacionGanadora(4) = combinacionGanadora(4)
        'combinacionGanadora(5) = combinacionGanadora(5)


        'recorremos el array y mostramos por consola el valor que queramos comprobar'
        For Each num In combinacionGanadora
            numerosArray += num & " "
        Next
        'mostramos por consola el reintegro'
        Console.WriteLine(combinacionGanadora(6))

    End Function

    Public Sub generarAleatorios_Click(sender As Object, e As EventArgs) Handles generarAleatorios.Click

        mostrar_resultados_sorteo()


    End Sub

    Public Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        'Borramos el resultado aleatorio de la combinacion ganadora'

        numero1.Text = ""
        numero2.Text = ""
        numero3.Text = ""
        numero4.Text = ""
        numero5.Text = ""
        numero6.Text = ""
        reintegro.Text = ""

        mostrar_resultados_sorteo()

    End Sub



    Private Sub borrarSeleccion_Click() Handles borrarSeleccion.Click
        'vaciamos los checkBox marcados del panel donde se generan los checkbox'
        For Each element As Control In checkboxPanel.Controls
            If TypeOf element Is CheckBox Then
                Dim chk As CheckBox = CType(element, CheckBox)
                chk.Checked = False
            End If
        Next

    End Sub



    Private Sub botonManual_Click_1(sender As Object, e As EventArgs) Handles botonManual.Click

        Dim checkboxesmarked As Integer = 0
        Resultados.labelAciertos.Text = "Has acertado "
        ' Comprueba que solo tenemos 6 checkboxes marcados
        ' Si no es asi saco un mensaje
        For i = 0 To checkboxPanel.Controls.Count - 1
            Dim checkbox As CheckBox
            checkbox = checkboxPanel.Controls(i)
            If checkbox.Checked = True Then
                checkboxesmarked += 1
            End If
        Next

        ' Si tenemos 6 checkboxes voy metiendo en una lista los valores
        ' Y luego lo copio en el vector de la combinacion del usuario
        Dim listaMarcados As New List(Of Integer)()
        If checkboxesmarked = 6 Then
            For i = 0 To checkboxPanel.Controls.Count - 1
                Dim checkbox As CheckBox
                checkbox = checkboxPanel.Controls(i)
                If checkbox.Checked = True Then
                    listaMarcados.Add(checkbox.Text.ToString)
                End If
            Next

            For i = 0 To listaMarcados.Count - 1
                combinacionUsuario(i) = listaMarcados(i)
            Next
            ComprobarAciertos()
        Else
            MessageBox.Show("numero incorrecto, pulse solo 6 casillas", "Error")
        End If



    End Sub
    Public Sub ComprobarAciertos()
        Resultados.ShowDialog()
    End Sub

    Private Sub botonAutomatico_Click_1(sender As Object, e As EventArgs) Handles botonAutomatico.Click
        Resultados.labelAciertos.Text = "Has acertado "
        combinacionUsuario = generarCombinacion(5)
        borrarSeleccion_Click()
        num7 = RandomNumber.Next(10)
        ComprobarAciertos()
        ''borrarDatos()
        mostrar_resultados_sorteo()


    End Sub

    Private Function borrarDatos() As Object
        numero1.Text = ""
        numero2.Text = ""
        numero3.Text = ""
        numero4.Text = ""
        numero5.Text = ""
        numero6.Text = ""
        reintegro.Text = ""
        mostrar_resultados_sorteo()
        Erase combinacionUsuario

    End Function

    Private Function generarCombinacion(tamano As Integer)
        'Generamos combinacion aleatoria

        Dim combinacion(tamano) As Integer
        Dim numero As Integer

        For i = 0 To combinacion.Length - 1
            numero = RandomNumber.Next(1, 50)

            If i = 0 Then
                combinacion(i) = numero
            Else
                numero = RandomNumber.Next(1, 50)
                While repetido(combinacion, numero) = True
                    numero = RandomNumber.Next(1, 50)
                End While
                combinacion(i) = numero
            End If
        Next i


        Array.Sort(combinacion)
        Return combinacion

    End Function

    Private Function repetido(lista() As Integer, numero As Integer)

        If Array.IndexOf(lista, numero) = -1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub recogerentradaManual()
    End Sub

End Class
