Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 75 Then
            TextBox2.Text = "A"
            Label4.Text = "Exellent"
            Label4.ForeColor = Color.Red
        ElseIf TextBox1.Text >= 65 Then
            TextBox2.Text = "B"
            Label4.Text = "Very Good"
            Label4.ForeColor = Color.Green
        ElseIf TextBox1.Text >= 55 Then
            TextBox2.Text = "C"
            Label4.Text = "Good"
            Label4.ForeColor = Color.Blue
        ElseIf TextBox1.Text >= 35 Then
            TextBox2.Text = "S"
            Label4.Text = "Simple"
            Label4.ForeColor = Color.Red
        ElseIf TextBox1.Text < 35 Then
            TextBox2.Text = "F"
            Label4.Text = "Weak"
            Label4.ForeColor = Color.Black

        End If
    End Sub
End Class
