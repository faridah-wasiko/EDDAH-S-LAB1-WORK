Public Class Form2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub btnLoadPic_Click(sender As Object, e As EventArgs) Handles btnLoadPic.Click
        ' Load picture from file
        Dim dlg As New OpenFileDialog
        dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If dlg.ShowDialog = DialogResult.OK Then
            picBox.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub btnWelcome_Click(sender As Object, e As EventArgs) Handles txtWelcome.Click
        ' Show welcome text
        txtWelcome.Text = "Welcome to the Display Test Application!"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

End Class
