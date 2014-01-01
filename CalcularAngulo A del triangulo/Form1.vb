Public Class Form1
    Private Sub Angulos()
        'Declaramos la variables de tipo Double
        Dim anguloA, anguloB1, anguloB2, adyacente, hipotenusa, coseno As Double
        'Condición que valúa el TextBox si esta vacío
        If TextBox_Hipotenusa.Text = "" Then
            MessageBox.Show("Ingrese la hipotenusa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Colocamos el focus en el TextBox
            TextBox_Hipotenusa.Focus()
        Else
            'Condición que valúa el TextBox si esta vacío
            If TextBox_Adyacente.Text = "" Then
                MessageBox.Show("Ingrese la adyacente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Colocamos el focus en el TextBox
                TextBox_Adyacente.Focus()
            Else
                'Método que convierte en un tipo double el valor 
                'que se ingrese por los TextBox
                hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text)
                adyacente = Convert.ToDouble(TextBox_Adyacente.Text)
                'División de las variables adyacente/hipotenusa
                coseno = adyacente / hipotenusa
                'Formula para sacar el ángulo A
                anguloA = Math.Acos(coseno) * 180 / Math.PI
                Label_AnguloA.Text = anguloA.ToString()
                'Método para sacar el ángulo B
                anguloB1 = 90 + anguloA
                anguloB2 = 180 - anguloB1
                Label_AnguloB.Text = anguloB2.ToString()
            End If
        End If

    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        TextBox_Hipotenusa.Text = ""
        TextBox_Adyacente.Text = ""
        Label_AnguloA.Text = "0"
        Label_AnguloB.Text = "0"
        TextBox_Hipotenusa.Focus()

    End Sub

    Private Sub Button_Calular_Click(sender As Object, e As EventArgs) Handles Button_Calular.Click
        Angulos()
    End Sub
End Class
