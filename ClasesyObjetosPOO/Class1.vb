Public Class Class1
    'PROPIEDADES'
    Public nombre As String
    Public genero As String
    Public altura As String
    Public ciudad As String

    'CONSTRUCTOR'
    Public Sub New()

    End Sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.genero = genero
        Me.altura = altura
        Me.ciudad = ciudad
    End Sub

    'METODO'
    Public Function comer(Carne As String) As String
        Return Me.nombre & "genero " & Me.genero & "y mide " & Me.altura & "es de " & Me.ciudad & "comerá " & Carne
    End Function

    Public Function dormir(Ocho As String)
        Return Me.nombre & "genero " & Me.genero & "y mide " & Me.altura & "es de " & Me.ciudad & "Duerme " & Ocho
    End Function

End Class
