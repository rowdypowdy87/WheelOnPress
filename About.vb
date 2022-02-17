Public Class About
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBox1.Text = "Designed and programmed by Clinton Wheeler for UGL Limited 2020. " + Chr(13) + Chr(13) +
                            "Version " + My.Application.Info.Version.ToString + Chr(13) +
                            "Build " + My.Application.Info.Version.Build.ToString + Chr(13)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class