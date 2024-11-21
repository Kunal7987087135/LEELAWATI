Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value1, value2, answer As Integer
        value1 = TextBox1.Text
        value2 = TextBox2.Text
        answer = value1 + value2
        TextBox3.Text = answer
    End Sub
End Class