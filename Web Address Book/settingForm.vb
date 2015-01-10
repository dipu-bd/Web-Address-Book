Public Class settingForm

    Private Sub settingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = MainForm.defaultPath
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If Not checkvalidpath(TextBox1.Text) Then MsgBox("Directory dosen't exist. Please set a valid path for default directory.")
    End Sub

    Function checkvalidpath(ByVal path As String) As Boolean
        Return My.Computer.FileSystem.DirectoryExists(path)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "Select a directory from where the documents will be loaded."
        fbd.ShowNewFolderButton = False
        fbd.SelectedPath = MainForm.defaultPath
        If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = fbd.SelectedPath
        End If
    End Sub
End Class