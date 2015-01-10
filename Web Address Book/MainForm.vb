Public Class MainForm

#Region "Form Methods"

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LoadProfiles()
        Try
            Dim path As String = My.Application.CommandLineArgs(1)
            If My.Computer.FileSystem.DirectoryExists(path) Then LoadItems(path)
        Catch
            LoadItems(defaultDoc)
        End Try
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        saveSettings()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSettings()
    End Sub

    Public Sub saveSettings()
        My.Settings.Save()
    End Sub

    Public Sub loadSettings()
        If My.Settings.showGroup Then ShowGroupToolStripMenuItem.Text = "Hide Group"
        ProfileLayoutPanel.RowStyles(2).Height = 14
        AddressLayoutPanel.RowStyles(2).Height = 14
        web_priority.SelectedIndex = 2
        For Each itm As String In Split(My.Settings.groupAutoComplete, ";")
            If itm.Trim = "" Then Continue For
            If Not web_group.Items.Contains(itm) Then web_group.Items.Add(itm)
        Next
    End Sub
#End Region

#Region "Properties"

    Shared ReadOnly Property RegistryPath() As String
        Get
            Return "HKEY_CURRENT_USER\Softwares\Sand Soft Inc\Web Address Book"
        End Get
    End Property

    Shared Property defaultPath() As String
        Get
            Dim val As Object = My.Computer.Registry.GetValue(RegistryPath, "DefaultPath", Nothing)
            If val Is Nothing Then : Return CurDir()
            Else : Return val.ToString() : End If
        End Get
        Set(ByVal value As String)
            My.Computer.Registry.SetValue(RegistryPath, "DefaultPath", value)
        End Set
    End Property

    Shared Property defaultDoc() As String
        Get
            Dim val As Object = My.Computer.Registry.GetValue(RegistryPath, "DefaultDoc", Nothing)
            If val Is Nothing Then : Return ""
            Else : Return val.ToString() : End If
        End Get
        Set(ByVal value As String)
            My.Computer.Registry.SetValue(RegistryPath, "DefaultDoc", value)
        End Set
    End Property

    Property lastPath() As String
        Get
            Dim val As Object = My.Computer.Registry.GetValue(RegistryPath, "LastDoc", Nothing)
            If val Is Nothing Then : Return defaultDoc
            Else : Return val.ToString() : End If
        End Get
        Set(ByVal value As String)
            My.Computer.Registry.SetValue(RegistryPath, "LastDoc", value)
        End Set
    End Property

    Property lastDoc() As XmlDocument
        Get
            Dim doc As New XmlDocument : doc.Load(lastPath)
            Return doc
        End Get
        Set(ByVal value As XmlDocument)
            value.Save(lastPath)
        End Set
    End Property
#End Region

#Region "Loader Methods"

    Sub addProfile(ByVal file As String, Optional ByVal user As Boolean = True)
        Try
            Dim doc As New XmlDocument : doc.Load(file)
            Dim nam As String = doc.DocumentElement.Attributes("name").InnerXml
            Dim indx As Integer = CInt(doc.DocumentElement.Attributes("security").InnerXml)
            Dim litm As New ListViewItem(New String() {nam, ""}, indx) : litm.Tag = file
            If user Then : litm.Group = ProfileList.Groups(indx)
            Else : litm.Group = ProfileList.Groups(2) : End If
            Dim itm As ListViewItem = ProfileList.Items.Add(litm)
            If defaultDoc = file Then SetAsDefault(itm)
        Catch ex As Exception
            If Not user Then MsgBox("Can't open the document." & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub

    Sub SetAsDefault(ByVal litm As ListViewItem)
        litm.SubItems(1).Text = "Default"
        litm.UseItemStyleForSubItems = False
        litm.SubItems(1).Font = New Font(ProfileList.Font, FontStyle.Italic)
        litm.SubItems(1).ForeColor = Color.DarkRed
        litm.Selected = True
        'remove other from list
        Try : Dim itm As ListViewItem = CType(ProfileList.Tag, ListViewItem)
            itm.SubItems(1).Text = "" : Catch : End Try
        ProfileList.Tag = litm
    End Sub

    Sub LoadProfiles()
        ProfileList.Items.Clear()
        For Each file As String In My.Computer.FileSystem.GetFiles(defaultPath, FileIO.SearchOption.SearchAllSubDirectories)
            If Not System.IO.Path.GetExtension(file) = ".adbs" Then Continue For
            addProfile(file)
        Next
    End Sub

    Sub LoadItems(ByVal path As String, Optional ByVal src As String = "")
        BackgroundWorker1.CancelAsync()
        AddressList.Items.Clear() : lastPath = path
        SmallImageList.Images.Clear() : LargeImageList.Images.Clear()
        LargeImageList.Images.Add("def", My.Resources.large_web)
        SmallImageList.Images.Add("def", My.Resources.small_web)
        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync(src)
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim doc As XmlDocument = lastDoc
            Dim src As String = e.Argument.ToString()
            'load items
            For i As Integer = 0 To doc.DocumentElement.ChildNodes.Count - 1
                If (BackgroundWorker1.CancellationPending) Then Return
                Dim child As XmlNode = doc.DocumentElement.ChildNodes(i)
                Dim nam, info, url As String
                Dim pri As String = "2\n", group As String = "Default\n"
                Dim img As Bitmap = Nothing
                Dim nc As Integer = child.ChildNodes.Count
                nam = child.ChildNodes(0).InnerXml
                info = child.ChildNodes(1).InnerXml
                url = child.ChildNodes(2).InnerXml
                If (nc >= 4) Then pri = child.ChildNodes(3).InnerXml
                If (nc >= 5) Then
                    Try : img = getImgFromData(child.ChildNodes(4).InnerXml) : Catch : End Try
                End If
                If (nc >= 6) Then group = child.ChildNodes(5).InnerXml
                'check src
                Dim tooltip As String = "Name: " & nam & "\n(" & info & ")\nURL: " & url _
                    & "\nPriority: " & web_priority.Items(CInt(pri)).ToString() & "\nGroups: " & group
                If Not (src = "") Then
                    Dim txt As String = (nam & " " & url & " " & info & " " & group).ToLower()
                    Dim cont As Boolean = False
                    For Each itm As String In src.Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
                        cont = cont Or txt.Contains(itm.Trim())
                    Next
                    If Not cont Then Continue For
                End If
                '//new item
                Dim litm As New ListViewItem(New String() {nam, info, url, pri, group}, 0)
                litm.ToolTipText = tooltip
                '//report
                BackgroundWorker1.ReportProgress(i, New Object() {litm, img, group})
            Next
            Dim docnam As String = doc.DocumentElement.Attributes("name").InnerXml
            Me.Text = "Web Address Book - " & docnam
        Catch : End Try
    End Sub

    Dim groups As String = ""
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Dim states As Object() = CType(e.UserState, Object())
        Dim litm As ListViewItem = CType(states(0), ListViewItem)
        Dim img As Bitmap = CType(states(1), Bitmap)
        Dim group As String = states(2).ToString()
        'add group
        Try : AddressList.Groups(group).Items.Add(litm)
        Catch
            AddressList.Groups.Add(group, group).Items.Add(litm)
            If Not My.Settings.groupAutoComplete.Contains(group) Then My.Settings.groupAutoComplete &= group & ";"
        End Try
        'add image
        If Not (img Is Nothing) Then
            LargeImageList.Images.Add(img) : SmallImageList.Images.Add(img)
            litm.ImageIndex = LargeImageList.Images.Count - 1
        End If
        'add item
        AddressList.Items.Add(litm).Tag = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        AddressList.Focus()
        AddressList.Tag = lastPath
    End Sub

#Region "Functions"
    Function getImgFromData(ByVal data As String) As Bitmap
        Dim img As New Bitmap(32, 32)
        Dim row() As String = data.Split(New String() {";"}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To 31
            Dim itm() As String = row(i).Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
            For j As Integer = 0 To 31
                Dim [color] As Color = color.FromArgb(CInt(itm(j)))
                img.SetPixel(i, j, [color])
            Next
        Next
        Return img
    End Function
    Function getDataFromImg(ByVal img As Bitmap) As String
        img = New Bitmap(img, 32, 32)
        Dim res As String = ""
        For i As Integer = 0 To 31
            For j As Integer = 0 To 31
                res &= img.GetPixel(i, j).ToArgb.ToString() & " "
            Next
            res &= ";"
        Next
        Return res
    End Function
#End Region
#End Region


#Region "Style Methods"

    Private Sub TextBox_GotFocus(ByVal sender As TextBox, ByVal defTxt As String)
        If sender.Text = defTxt Then
            sender.Text = ""
            sender.Font = New Font(sender.Font, FontStyle.Regular)
        End If
        sender.ForeColor = Color.Black
    End Sub

    Private Sub TextBox_LostFocus(ByVal sender As TextBox, ByVal defTxt As String, ByVal alwayesGray As Boolean)
        If sender.Text.Trim = "" Then
            sender.Text = defTxt
            sender.Font = New Font(sender.Font, FontStyle.Italic)
            sender.ForeColor = Color.Gray
        End If
        If alwayesGray Then sender.ForeColor = Color.Gray
    End Sub
#End Region

#Region "Profile Browser"

    '********* IMPORTANT METHODS *************
    Sub ClearProfileBoxes()
        profile_name.Text = "" : TextBox_LostFocus(profile_name, "Profile Name", True)
        profile_pass1.Text = "" : TextBox_LostFocus(profile_pass1, "Set a Password", True)
        profile_pass2.Text = "" : TextBox_LostFocus(profile_pass2, "Retype Password", True)
        profile_add.Text = "Add" : profile_add.Tag = -1
        profile_pass1.PasswordChar = Nothing : profile_pass2.PasswordChar = Nothing
    End Sub

    Private Sub profile_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_add.Click

    End Sub

    Private Sub ProfileList_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfileList.ItemActivate
        searchBox.Text = ""
        LoadItems(ProfileList.SelectedItems(0).Tag.ToString())
    End Sub

    '********* 2nd Class Methods *****************
    Private Sub ProfileList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileList.SelectedIndexChanged
        Dim sel As Boolean = CBool(ProfileList.SelectedItems.Count = 0)
        ToolStripSeparator4.Visible = Not sel
        EditProfileToolStripMenuItem.Visible = Not sel
        DeleteToolStripMenuItem1.Visible = Not sel
        If (Not sel) Then
            Try
                Dim isex As Boolean = CBool(ProfileList.SelectedItems(0).Group.Header = "External")
                SaveToolStripMenuItem.Visible = isex
                SetAsDefaultTool1.Visible = CBool((Not isex) And (ProfileList.SelectedItems(0).SubItems(1).Text = ""))
            Catch : End Try
        End If
        SaveToolStripMenuItem.Visible = sel
        SetAsDefaultTool1.Visible = sel
    End Sub

    Private Sub profile_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_cancel.Click
        ClearProfileBoxes() : ProfileList.Focus()
    End Sub

    Private Sub HideProfileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideProfileButton.Click, ShowProfileButton.Click
        Dim state As Boolean = SplitContainer1.Panel1Collapsed
        SplitContainer1.Panel1Collapsed = Not state
        ShowProfileButton.Visible = Not state
        If (Not state And Me.Width > 350) Then Me.Width = 370
        If (state And Me.Width < 480) Then Me.Width = 520
    End Sub

    '************ 3rd Class Methods ***********
    Private Sub isProtected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isProtected.CheckedChanged
        profile_pass1.Enabled = True : profile_pass1.BackColor = Color.Snow
        profile_pass2.Enabled = True : profile_pass2.BackColor = Color.Snow
    End Sub

    Private Sub isPublic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isPublic.CheckedChanged
        profile_pass1.Enabled = False : profile_pass1.BackColor = Color.WhiteSmoke
        profile_pass2.Enabled = False : profile_pass2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub AddProfileBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProfileBox.Enter
        ProfileLayoutPanel.RowStyles(2).Height = 125
    End Sub

    Private Sub AddProfileBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddProfileBox.Leave
        ProfileLayoutPanel.RowStyles(2).Height = 14
    End Sub

    Private Sub AddProfileBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AddProfileBox.MouseClick
        profile_name.Focus()
    End Sub

    Private Sub profile_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_name.GotFocus
        TextBox_GotFocus(profile_name, "Profile Name")
    End Sub
    Private Sub profile_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_name.LostFocus
        TextBox_LostFocus(profile_name, "Profile Name", False)
    End Sub

    Private Sub profile_pass1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_pass1.GotFocus
        TextBox_GotFocus(profile_pass1, "Set a Password")
        profile_pass1.PasswordChar = Chr(Asc("*"))
    End Sub
    Private Sub profile_pass1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_pass1.LostFocus
        TextBox_LostFocus(profile_pass1, "Set a Password", False)
        If profile_pass1.ForeColor = Color.Gray Then profile_pass1.PasswordChar = Nothing
    End Sub

    Private Sub profile_pass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_pass2.GotFocus
        TextBox_GotFocus(profile_pass2, "Retype Password")
        profile_pass2.PasswordChar = Chr(Asc("*"))
    End Sub
    Private Sub profile_pass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_pass2.LostFocus
        TextBox_LostFocus(profile_pass2, "Retype Password", False)
        If profile_pass2.ForeColor = Color.Gray Then profile_pass2.PasswordChar = Nothing
    End Sub

    Private Sub ProfileLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileLabel.Click
        ProfileList.SelectedItems.Clear()
        ProfileContext.Show(ProfileLabel, ProfileList.Location)
    End Sub
#End Region

#Region "Add Web Address"
    '********* IMPORTANT ******************
    Sub ClearAddressBox()

    End Sub

    '************* 2nd Class *****************
    Private Sub web_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_add.Click

    End Sub

    Private Sub web_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_img.Click

    End Sub

    Private Sub Group1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Group1.Click
        web_name.Focus()
    End Sub
    Private Sub Group1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group1.Enter
        AddressLayoutPanel.RowStyles(2).Height = 125
    End Sub
    Private Sub Group1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Group1.Leave
        AddressLayoutPanel.RowStyles(2).Height = 14
    End Sub
    Private Sub web_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_cancel.Click
        ClearAddressBox() : AddressList.Focus()
    End Sub

    '*******************3rd class********************
    Private Sub web_info_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles web_info.GotFocus
        TextBox_GotFocus(web_info, "Short Info")
    End Sub
    Private Sub web_info_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles web_info.LostFocus
        TextBox_LostFocus(web_info, "Short Info", False)
    End Sub

    Private Sub web_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles web_name.GotFocus
        TextBox_GotFocus(web_name, "Website name")
    End Sub
    Private Sub web_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles web_name.LostFocus
        TextBox_LostFocus(web_name, "Website name", False)
    End Sub

    Private Sub web_priority_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_priority.GotFocus
        web_priority.DroppedDown = True
    End Sub
    Private Sub web_priority_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_priority.LostFocus
        web_priority.DroppedDown = False
    End Sub
#End Region

    Private Sub AddressList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressList.SelectedIndexChanged
        Dim sel As Boolean = CBool(AddressList.SelectedItems.Count = 0)
        'make visible if no item is selected
        viewAsToolStripMenuItem.Visible = sel
        sortByToolStripMenuItem.Visible = sel
        refreshToolStripMenuItem.Visible = sel
        'make visible if at least one item is selected
        OpenURLToolStripMenuItem.Visible = Not sel
        CopyURLToolStripMenuItem.Visible = Not sel
        EditToolStripMenuItem.Visible = Not sel
        saveIconMenuItm.Visible = Not sel
        ToolStripSeparator2.Visible = Not sel
        DeleteToolStripMenuItem.Visible = Not sel
    End Sub

#Region "Search Box"
    Private Sub searchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchBox.GotFocus
        TextBox_GotFocus(searchBox, "Quick Search")
    End Sub

    Private Sub searchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchBox.LostFocus
        TextBox_LostFocus(searchBox, "Quick Search", True)
    End Sub

    Private Sub searchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBox.TextChanged
        removeSearchString.Visible = False
        If searchBox.Font.Style = FontStyle.Italic Then Return
        Dim src As String = searchBox.Text.Trim.ToLower
        removeSearchString.Visible = Not CBool(src = "")
        AddressList.SelectedItems.Clear()
        For Each itm As ListViewItem In AddressList.Items
            If itm.Text.ToLower.Contains(src) Then
                itm.Selected = True : itm.EnsureVisible() : Exit For
            End If
        Next
    End Sub

    Private Sub searchBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles searchBox.KeyDown
        Dim src As String = searchBox.Text.Trim.ToLower
        If src = "" Then : LoadItems(AddressList.Tag.ToString()) : Return : End If
        If e.KeyCode = Keys.Enter Then LoadItems(AddressList.Tag.ToString, src)
    End Sub

    Private Sub removeSearchString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeSearchString.Click
        searchBox.Text = "" : LoadItems(AddressList.Tag.ToString)
    End Sub
#End Region

#Region "Profile COntex Menu"
    Private Sub SetAsDefaultTool1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsDefaultTool1.Click
        Try
            Dim litm As ListViewItem = ProfileList.SelectedItems(0)
            defaultDoc = litm.Tag.ToString()
            litm.SubItems(1).Text = "Default"
            litm.UseItemStyleForSubItems = False
            litm.SubItems(1).Font = New Font(ProfileList.Font, FontStyle.Italic)
            litm.ForeColor = Color.DarkRed
            litm.Selected = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProfileToolStripMenuItem.Click

    End Sub

    Private Sub AddNewProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewProfileToolStripMenuItem.Click
        ClearProfileBoxes() : profile_name.Focus()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim source As String = ProfileList.SelectedItems(0).Tag.ToString()
            Dim dest As String = defaultPath & "\" & System.IO.Path.GetFileNameWithoutExtension(source)
            Dim count As Integer = 1
            While My.Computer.FileSystem.FileExists(dest & ".adbs")
                dest &= "_" & count : count += 1
            End While
            My.Computer.FileSystem.CopyFile(source, dest & ".adbs")
            ProfileList.SelectedItems(0).Tag = dest & ".adbs"
            ProfileList.SelectedItems(0).Group = ProfileList.Groups(0)
        Catch ex As Exception
            MsgBox("Can't save." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem1.Click
        If settingForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            ShowGroupToolStripMenuItem.PerformClick()
        End If
    End Sub
#End Region

    Private Sub ShowGroupToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowGroupToolStripMenuItem.Click
        My.Settings.showGroup = Not My.Settings.showGroup
        If My.Settings.showGroup Then : ShowGroupToolStripMenuItem.Text = "Hide Groups"
        Else : ShowGroupToolStripMenuItem.Text = "Show Groups" : End If
    End Sub
End Class
