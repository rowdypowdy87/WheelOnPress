Public Class AdminOptionsWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainWindow.RamDia = Val(TBRamDia.Text)
        MainWindow.RamMax = Val(TextBox1.Text)
        DynamicDA = CheckBox1.Checked
        SaveSettings()
        Me.Hide()
    End Sub

    Private Sub AdminOptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBRamDia.Text = MainWindow.RamDia
        TextBox1.Text = MainWindow.RamMax
        CheckBox1.Checked = DynamicDA
        Label3.Text = "Ram Area = " & CStr(Math.Round(MainWindow.RamArea, 2)) & "m2"
        LoadSettings()
    End Sub

    Private Sub TBRamDia_Leave(sender As Object, e As EventArgs) Handles TBRamDia.Leave
        MainWindow.RamArea = (Math.PI * ((MainWindow.RamDia / 2) ^ 2)) / 1000
        Label3.Text = "Ram Area = " & CStr(Math.Round(MainWindow.RamArea, 2)) & "m2"
    End Sub

    Private Sub TBRamDia_TextChanged(sender As Object, e As EventArgs) Handles TBRamDia.TextChanged
        MainWindow.RamArea = (Math.PI * ((Val(TBRamDia.Text) / 2) ^ 2)) / 1000
        Label3.Text = "Ram Area = " & CStr(Math.Round(MainWindow.RamArea, 2)) & "m2"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DynamicDA = CheckBox1.Checked
    End Sub
End Class