Public Class Form1
    Private num1, num2, result As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = num1 - num2
        TextBox3.Text = Str(result)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        num2 = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        num1 = Val(TextBox1.Text)
    End Sub
End Class
