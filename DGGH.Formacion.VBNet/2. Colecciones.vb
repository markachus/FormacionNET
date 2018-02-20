Module Colecciones
    Sub Main()

#Region "Colecciones"
        'https://docs.microsoft.com/en-us/dotnet/standard/collections/

        'No genéricas
        Dim listanogenerica As ArrayList = New ArrayList() '¿Porqué se reconoce el tipo ArrayList?
        listanogenerica.Add(1)
        listanogenerica.Add("1")
        listanogenerica.Add(DateTime.Today)
        listanogenerica.Add(Date.Today)
        listanogenerica.Add(True)

        'Genéricas
        Dim listagenerica As List(Of Date) = New List(Of Date)()
        listagenerica.Add(Date.Today)
        listagenerica.Add(New Date(2018, 12, 1))
        listagenerica.Add(New DateTime(2018, 12, 1))
        'listagenerica.Add(True) 'Descomenta esto
        'listagenerica.Add(1) 'Descomenta esto
        'listagenerica.Add("1") 'Descomenta esto


        'Operaciones con genericas -> Fíjate en los tipos de los parámetros
        Dim listagenerica2 As New List(Of String)
        listagenerica2.Add("BA")
        listagenerica2.AddRange({"SU", "RI", "MA", "LY", "MD", "GA", "PE", "CR"})
        listagenerica2.Insert(3, "GO") ' Ups, olvidé el Gótico
        listagenerica2.Contains("MA") '¿Qué es eso comparado con la inmensidad del Hotel Mar?
        Console.WriteLine(listagenerica2(5))
        listagenerica2.IndexOf("GA")
        listagenerica2.Remove("BA") 'Quitamos el barcino hasta que se abra

#End Region

#Region "Programilla con Colecciones y Expresiones Lambda"

        Dim moviles As List(Of String) = New List(Of String)(
                {"ZTE Axon",
                "LG Q6",
                "Sony Xperia XZ1",
                "Iphone 7",
                "Huaweii P10",
                "Huaweii P8",
                "Huaweii Nova Plus",
                "Samsung Galaxy 4",
                "Samsung Galaxy S7",
                "BQ Aquaris M5",
                "BQ X Pro",
                "Xiaomi MIA1",
                "Nokia 6",
                "Nokia 3210",
                "Nokia 3330"})

        Console.WriteLine("Listando moviles...")
        moviles.ForEach(Sub(s) Console.WriteLine(s))
        Console.WriteLine("")

        moviles.Add("Nokia 5")
        Console.WriteLine(moviles.Last() & " añadido")
        Console.WriteLine("")

        Console.WriteLine("Ordenando...")
        moviles.Sort()
        moviles.ForEach(Sub(s) Console.WriteLine(s))
        Console.WriteLine("")

        Console.WriteLine("Girando orden....")
        moviles.Reverse()
        moviles.ForEach(Sub(s) Console.WriteLine(s))
        Console.WriteLine("")

        Console.WriteLine("Buscando Nokias...")
        Dim nokias = moviles.FindAll(Function(s) s.StartsWith("nokia", StringComparison.CurrentCultureIgnoreCase))
        nokias.ForEach(Sub(s) Console.WriteLine(s))
        Console.WriteLine("")

        Console.WriteLine("¿Existe algun Iphone?")
        Dim iphones = moviles.FindAll(Function(m) m.StartsWith("Iphone", StringComparison.CurrentCultureIgnoreCase))
        Console.WriteLine(IIf(iphones.Count > 0, "Sí", "No"))
        Console.WriteLine("")

        Console.WriteLine("Eliminando Iphones...")
        For Each ip In iphones
            moviles.Remove(ip)
        Next

        moviles.ForEach(Sub(s) Console.WriteLine(s))
        Console.WriteLine("")
        Console.ReadLine()

#End Region

    End Sub

End Module
