Public Class Delegados

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
    End Sub
#End Region

#Region "Delegados predefinidos"

    Dim operacionAsFunc As Func(Of Integer, Integer, Integer)

    'Sub B()

    'End Sub
#End Region

End Class
