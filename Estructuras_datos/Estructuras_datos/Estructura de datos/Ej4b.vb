Module Ej4b

    Sub main()

        Dim vector_codigos = New Integer() {1, 2, 3, 4, 5}
        Dim vector_lugares = New String() {"Pto Rico", "Bedoya", "Retiro", "Eldorado", "Tecla"}
        Dim vector_precios = New Single() {120.5, 45, 1400, 185.5, 55.1}
        Dim codigo, posi As UShort
        Dim Cantidad As Integer
        Dim subtotal_a_cobrar, total_a_cobrar As Single

        Do
            Console.WriteLine("Ingrese codigo de venta (Ingrese 0 para salir): ")
            codigo = Console.ReadLine()

            If codigo <> 0 Then
                For x = 0 To vector_codigos.Length - 1
                    If codigo = vector_codigos(x) Then
                        posi = x
                    End If
                Next

                Console.WriteLine("Destino: " & vector_lugares(posi) & vbNewLine & "Precio: " & vector_precios(posi))
                Console.WriteLine("Ingrese Cantidad de viajes: ")
                Cantidad = Console.ReadLine()
                subtotal_a_cobrar = vector_precios(posi) * Cantidad
                Console.WriteLine("Precio Viaje: " & subtotal_a_cobrar)
                total_a_cobrar += subtotal_a_cobrar
                Console.WriteLine("total a cobrar: " & total_a_cobrar)

            End If
        Loop While Codigo <> 0

        Console.WriteLine("Gracias por utilizar nuestros servicios.")
        Console.ReadKey()
    End Sub

End Module