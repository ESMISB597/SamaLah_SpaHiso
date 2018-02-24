Public Class Mainpage_SMH
    Private Sub Mainpage_SMH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Time_Proc_Tick(sender As Object, e As EventArgs) Handles Time_Proc.Tick
        Time_Proc.Start()
        TimeLabel.Text = TimeString()
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        UserName_Box.Text = ""
        Password_Box.Text = ""
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
