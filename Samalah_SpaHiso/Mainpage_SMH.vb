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

    Private Sub Login_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Hide()
        CustomerRegister.Show()
    End Sub

    Private Sub Login_Button_Click_1(sender As Object, e As EventArgs) Handles Login_Button.Click
        ListBox1.Items.Add("กำลังต่อฐานข้อมูล")
    End Sub
End Class
