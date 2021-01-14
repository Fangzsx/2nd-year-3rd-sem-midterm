Public Class Form1

    Private radius, result As Double
    Const pi = 3.1416

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        radius = Val(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = (4 / 3) * pi * (radius * radius * radius)
        TextBox2.Text = Str(result)
    End Sub
End Class
