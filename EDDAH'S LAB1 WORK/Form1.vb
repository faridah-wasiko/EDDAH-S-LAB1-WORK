Public Class Form1
    Private Sub FormOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tooltips
        ToolTip1.SetToolTip(btnLoadDemo, "Click to open the Object Demonstrations form")
        ToolTip1.SetToolTip(btnExit, "Click to exit the application")
    End Sub

    Private Sub btnLoadDemo_Click(sender As Object, e As EventArgs) Handles btnLoadDemo.Click
        ' Load and display the second form
        Dim objForm As New Object
        objForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Application.Exit()
    End Sub
    Private Sub FormOne_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize and change background color
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
End Class
