Public Module Delegados

#Region "Delegados puros"

    Delegate Function Operacion(x As Integer, y As Integer) As Integer 'Delegate -> palabra reservada

    Function Suma(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    Function Multiplicacion(x As Integer, y As Integer) As Integer
        Return x * y
    End Function

    Dim op As Operacion = AddressOf Suma
    Dim res As Integer = op(1, 1)

    Sub A(op As Operacion, x As Integer, y As Integer)
        Dim res = op(x, y)
        Console.WriteLine(res)
    End Sub

    Sub Main()
        A(AddressOf Suma, 1, 1)
        A(AddressOf Multiplicacion, 1, 1)

        A(Function(x As Integer, y As Integer) As Integer
              Return x - y
          End Function, 1, 1)

        A(Function(x, y) x - y, 1, 1)

        B(Function(x, y) x + y, 1, 1)
    End Sub
#End Region

#Region "Delegados predefinidos y expresiones lambda"

    Dim operacionAsFunc As Func(Of Integer, Integer, Integer)
    Dim operacionasAAction As Action(Of Integer, Integer)
    Dim operacionAsPredicate As Predicate(Of Integer)

    Sub B(op As Func(Of Integer, Integer, Integer), x As Integer, y As Integer)
        Dim res = op(x, y)
        Console.WriteLine(res)
    End Sub

    Sub Main2()
        B(AddressOf Suma, 1, 1)
        B(AddressOf Multiplicacion, 1, 1)

        B(Function(x As Integer, y As Integer) As Integer
              Return x - y
          End Function, 1, 1)

        B(Function(x, y) x - y, 1, 1)

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

        'Operaciones de List(OF T)
        Dim huaweiip10 = moviles.Find(Function(s) s = "Huaweii P10")
        Dim todosLosHuaweiis = moviles.FindAll(Function(s) s.StartsWith("Huaweii"))
        Dim existe = moviles.Exists(Function(s) s.StartsWith("BQ"))
        moviles.Sort()
        moviles.Reverse()

        Dim tablets As New List(Of String)
        tablets.AddRange({"Surface Pro", "BQ X Pro", "Samsung Galaxy Note 8''", "Kindle Fire", "BQ Edison Mini", "Kindle DX", "Ipad Mini", "Huaweii Media Pad 3", "Nokia 6"})

        Dim notexist = moviles.Except(tablets)
        Dim interseccion = moviles.Intersect(tablets)

        'Operacion usando System.Collections.Generic.List
        moviles.Find(Function(s) s = "BQ Aquaris M5")
        'Extensiones de System.Linq.Enumerable
        moviles.Where(Function(s) s = "BQ Aquaris M5").First()


    End Sub

#End Region


End Module
