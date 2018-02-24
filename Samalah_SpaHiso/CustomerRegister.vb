Public Class CustomerRegister
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub SaveToDB_Button_Click(sender As Object, e As EventArgs) Handles SaveToDB_Button.Click
        Label10.Text = TextBox1.Text + " " + TextBox2.Text
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
    End Sub

    Private Sub Backtomain_Click(sender As Object, e As EventArgs) Handles Backtomain.Click
        Me.Hide()
        Mainpage_SMH.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class