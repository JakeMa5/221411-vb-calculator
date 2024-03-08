Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim varNumber1 As Integer
        Dim varNumber2 As Integer

        varNumber1 = TextBox1.Text
        varNumber2 = TextBox2.Text

        TextBox3.Text = varNumber1 + varNumber2

    End Sub

End Class
