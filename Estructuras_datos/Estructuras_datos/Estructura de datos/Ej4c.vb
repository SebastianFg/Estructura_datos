Module Ej4c

    Private vector_notas() As Single

    Sub Main()
        Console.WriteLine("Ingrese cantidad de alumnos")
        Dim cantidad_alumnos As Byte = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad de notas")
        Dim cantidad_notas As Byte = Console.ReadLine()
        For contador = 1 To cantidad_notas
            Dim nota As UShort
            Console.WriteLine("Ingrese notas")
            nota = Console.ReadLine()
            vector_notas(contador) = nota
        Next



        Console.ReadKey()
    End Sub

End Module