Public Class Form1

    Private inch, result As Double
    Const multiplier = 2.54

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = inch * multiplier
        TextBox2.Text = Str(result)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        inch = Val(TextBox1.Text)
    End Sub
End Class
