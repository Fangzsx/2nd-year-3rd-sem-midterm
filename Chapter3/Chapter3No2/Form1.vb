Public Class Form1

    Private fahrenheit, result As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        fahrenheit = Val(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = (5 / 9) * (fahrenheit - 32)
        TextBox2.Text = Str(result)
    End Sub
End Class
