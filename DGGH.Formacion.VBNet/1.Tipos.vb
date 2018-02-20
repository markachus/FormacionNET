Module Tipos
    Sub Main()

#Region "Conversiones implicitas"

        Dim numero1 As Integer = 1
        Dim numero2 As Integer = "2"
        Dim noesnumero As Integer = "cuatro"

        'PREGUNTA 1:  ¿Por qué compilan las líneas 2, 3, y 4? (Probad ahora a añadir o quitar Option Strict On)
        'PREGUNTA 2. ¿Se ejecutarían bien?
#End Region

#Region "Inferencias"
        Dim x = 5
        Dim hello = "Hola mundo"
        'PREGUNTA 3:  ¿De qué tipo son x y hello? 
        'PREGUNTA 4:  ¿Por qué compilan? Prueba a añadir Option Strict Off
        'PREGUNTA 5: En que estructuras de código se usan habitualmente variables anónimas


        'PREGUNTA 6: ¿De qué tipo es la variable hotel?
        Dim CTB As String = "BA"
        Dim hotel = New With {.Id = 1, .Nombre = "Hotel Barcino", CTB}

#End Region

#Region "Vectores"

        Dim pupurri(3) As Object
        pupurri(0) = 1
        pupurri(1) = "SU"
        pupurri(2) = New Hotel()
        'PREGUNTA6: ¿Por qué compila incluso con Option Strict On?

        Dim hoteles(3) As String
        hoteles(0) = "BA"
        hoteles(1) = "SU"
        hoteles(2) = "RI"


        'Diferentes manera de declarar e inicializar un vector
        Dim hotelesA(3) As String
        Dim hotelesB() As String

        Dim hotelesC() As String = New String() {"BA", "SU", "RI"} 'Tipo explicito + inicialización
        Dim hotelesD = New String() {"BA", "SU", "RI"} 'Tipo inferido + inicialización
        Dim hotelesE = {"BA", "SU", "RI"} 'Tipo inferido + inicialización

#End Region

    End Sub


    Public Class Hotel
    End Class

End Module
