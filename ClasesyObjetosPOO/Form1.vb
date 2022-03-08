Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim persona1 As Class1 = New Class1()
        persona1.nombre = "Amelia "
        persona1.genero = "Femenino "
        persona1.altura = "1.64 mt "
        persona1.ciudad = "Mazatenango"
        TextBox1.Text = persona1.comer("Pollo asado")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim persona2 As Class1 = New Class1()
        persona2.nombre = "Waldir "
        persona2.genero = "masculino "
        persona2.altura = "1.70 mt "
        persona2.ciudad = "Guatemala "
        TextBox1.Text = persona2.dormir("Ocho horas ")
    End Sub
End Class
