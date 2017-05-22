Module Ej4a

    Sub Main()

        Dim arreglo = New Integer() {10, 9, 8, 5, 1}
        Dim promedio As Single
        'For x = 0 To 4 Step 1
        '    Console.Write("Ingrese los numeros: ")
        '    arreglo(x) = Console.ReadLine()
        'Next
        Console.WriteLine("Los numeros a calcular la desviacio y la media son:")
        For Each numero As Integer In arreglo
            Console.Write(numero & " ")
        Next

        promedio = calculo_media(arreglo)

        Console.WriteLine(vbNewLine & "El promedio es: " & promedio)
        calculo_desviacion(arreglo, promedio)
        Console.ReadKey()
    End Sub

    Private Function calculo_media(vector() As Integer) As Single
        Dim suma_media As Single
        For x = 0 To vector.Length - 1
            suma_media += vector(x)
        Next
        Return suma_media / vector.Length()
    End Function

    Private Sub calculo_desviacion(vector() As Integer, media As Single)

        For x = 0 To vector.Length - 1
            Console.WriteLine("Numero: " & vector(x) & vbNewLine & "Desviacion: " & (vector(x) - media))
        Next
    End Sub

End Module