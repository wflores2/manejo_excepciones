Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Double
        r = 5 + 3 * 10
        Label1.Text = r
        r = (5 + 3) * 10
        Label2.Text = r
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, r As Double
        Try
            a = TextBox1.Text
            b = TextBox2.Text
            r = a + b
            TextBox3.Text = r
        Catch ex As Exception
            If MessageBox.Show(ex.Message) Then
                TextBox1.Focus()
            End If
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a, b, r As Double
        Try
            a = TextBox1.Text
            b = TextBox2.Text
            r = Val(a) \ Val(b)
            TextBox3.Text = r
        Catch ex As Exception
            If MessageBox.Show(ex.Message) Then
                TextBox1.Focus()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, r As Double
        Try
            a = TextBox1.Text
            b = TextBox2.Text
            r = Val(a) - Val(b)
            TextBox3.Text = r
        Catch ex As Exception
            If MessageBox.Show(ex.Message) Then
                TextBox1.Focus()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, r As Double
        Try
            a = TextBox1.Text
            b = TextBox2.Text
            r = Val(a) * Val(b)
            TextBox3.Text = r
        Catch ex As Exception
            If MessageBox.Show(ex.Message) Then
                TextBox1.Focus()
            End If
        End Try
    End Sub
End Class
