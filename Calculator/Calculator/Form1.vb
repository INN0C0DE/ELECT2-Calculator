Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total.Text = Val(num1.Text) / Val(num2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged

    End Sub

    Private Sub num2_TextChanged(sender As Object, e As EventArgs) Handles num2.TextChanged

    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
