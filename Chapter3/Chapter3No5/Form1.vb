Public Class Form1

    Private price, service, yearlyDepreciation, result As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = (price - service) / yearlyDepreciation
        TextBox4.Text = Str(result)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        yearlyDepreciation = Val(TextBox3.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        service = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        price = Val(TextBox1.Text)
    End Sub
End Class
