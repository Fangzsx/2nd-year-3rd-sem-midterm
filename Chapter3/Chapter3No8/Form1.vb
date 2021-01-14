Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim message = "Option button 1 is clicked!"
        TextBox1.Text = message
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim message = "Option button 2 is clicked!"
        TextBox1.Text = message
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim message = "Option button 3 is clicked!"
        TextBox1.Text = message
    End Sub


End Class
