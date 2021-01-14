Public Class Form1

    Private requirements, setupCost, inventory As Integer

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        setupCost = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        inventory = Val(TextBox3.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = Math.Sqrt(2 * ((requirements * setupCost) / inventory))
        TextBox4.Text = Str(result)
    End Sub

    Private result As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        requirements = Val(TextBox1.Text)
    End Sub
End Class
