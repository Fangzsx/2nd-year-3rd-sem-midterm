Public Class Form1

    Private amtDollar, convertedValue As Double
    Const pesoValue = 56.47

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        convertedValue = amtDollar * pesoValue
        TextBox2.Text = Str(convertedValue)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        amtDollar = Val(TextBox1.Text)
    End Sub








End Class
