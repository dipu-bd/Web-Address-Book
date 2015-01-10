<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Public", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Protected", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("External", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Test itm 1", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer)), New System.Drawing.Font("Segoe UI", 9.0!)), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Default", System.Drawing.Color.DarkRed, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer)), New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic))}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test itm 2"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer)), New System.Drawing.Font("Segoe UI", 9.0!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test itm 3"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer)), New System.Drawing.Font("Segoe UI", 9.0!))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test Itm", "This is a test itm", "www.test.com", "2"}, "default", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer)), New System.Drawing.Font("Segoe UI", 9.0!))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ProfileLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.ProfilePanel = New System.Windows.Forms.Panel
        Me.HideProfileButton = New System.Windows.Forms.Button
        Me.DefImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ProfileLabel = New System.Windows.Forms.Label
        Me.AddProfileBox = New System.Windows.Forms.GroupBox
        Me.profile_cancel = New System.Windows.Forms.Button
        Me.profile_add = New System.Windows.Forms.Button
        Me.profile_pass2 = New System.Windows.Forms.TextBox
        Me.profile_pass1 = New System.Windows.Forms.TextBox
        Me.isProtected = New System.Windows.Forms.RadioButton
        Me.isPublic = New System.Windows.Forms.RadioButton
        Me.profile_name = New System.Windows.Forms.TextBox
        Me.ProfileList = New System.Windows.Forms.ListView
        Me.ch1 = New System.Windows.Forms.ColumnHeader
        Me.ch2 = New System.Windows.Forms.ColumnHeader
        Me.ProfileContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetAsDefaultTool1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AddressLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.AddressList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.AddressContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.viewAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tiledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.detailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.smallIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sortByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.nameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uRLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.priorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ascndingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.descendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.saveIconMenuItm = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ShowGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.refreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Group1 = New System.Windows.Forms.GroupBox
        Me.web_group = New System.Windows.Forms.ComboBox
        Me.web_img = New System.Windows.Forms.Button
        Me.web_cancel = New System.Windows.Forms.Button
        Me.web_add = New System.Windows.Forms.Button
        Me.web_info = New System.Windows.Forms.TextBox
        Me.web_url = New System.Windows.Forms.TextBox
        Me.web_name = New System.Windows.Forms.TextBox
        Me.web_priority = New System.Windows.Forms.ComboBox
        Me.GroupLabel2 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.removeSearchString = New System.Windows.Forms.Button
        Me.searchBox = New System.Windows.Forms.TextBox
        Me.ShowProfileButton = New System.Windows.Forms.Button
        Me.TopPanel = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ProfileLayoutPanel.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        Me.AddProfileBox.SuspendLayout()
        Me.ProfileContext.SuspendLayout()
        Me.AddressLayoutPanel.SuspendLayout()
        Me.AddressContext.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.DataBindings.Add(New System.Windows.Forms.Binding("Panel1Collapsed", Global.Web_Address_Book.My.MySettings.Default, "sp1p1c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProfileLayoutPanel)
        Me.SplitContainer1.Panel1Collapsed = Global.Web_Address_Book.My.MySettings.Default.sp1p1c
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddressLayoutPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(504, 392)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'ProfileLayoutPanel
        '
        Me.ProfileLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.ProfileLayoutPanel.ColumnCount = 1
        Me.ProfileLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ProfileLayoutPanel.Controls.Add(Me.ProfilePanel, 0, 0)
        Me.ProfileLayoutPanel.Controls.Add(Me.AddProfileBox, 0, 2)
        Me.ProfileLayoutPanel.Controls.Add(Me.ProfileList, 0, 1)
        Me.ProfileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfileLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfileLayoutPanel.Name = "ProfileLayoutPanel"
        Me.ProfileLayoutPanel.RowCount = 3
        Me.ProfileLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ProfileLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ProfileLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.ProfileLayoutPanel.Size = New System.Drawing.Size(154, 392)
        Me.ProfileLayoutPanel.TabIndex = 1
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackgroundImage = Global.Web_Address_Book.My.Resources.Resources.lightBack11
        Me.ProfilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfilePanel.Controls.Add(Me.HideProfileButton)
        Me.ProfilePanel.Controls.Add(Me.ProfileLabel)
        Me.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(154, 24)
        Me.ProfilePanel.TabIndex = 0
        '
        'HideProfileButton
        '
        Me.HideProfileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HideProfileButton.BackColor = System.Drawing.Color.Lavender
        Me.HideProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HideProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HideProfileButton.FlatAppearance.BorderSize = 0
        Me.HideProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HideProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HideProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideProfileButton.ImageKey = "hide"
        Me.HideProfileButton.ImageList = Me.DefImageList
        Me.HideProfileButton.Location = New System.Drawing.Point(131, 2)
        Me.HideProfileButton.Name = "HideProfileButton"
        Me.HideProfileButton.Size = New System.Drawing.Size(20, 20)
        Me.HideProfileButton.TabIndex = 1
        Me.HideProfileButton.UseVisualStyleBackColor = False
        '
        'DefImageList
        '
        Me.DefImageList.ImageStream = CType(resources.GetObject("DefImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DefImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.DefImageList.Images.SetKeyName(0, "public")
        Me.DefImageList.Images.SetKeyName(1, "protected")
        Me.DefImageList.Images.SetKeyName(2, "show")
        Me.DefImageList.Images.SetKeyName(3, "hide")
        '
        'ProfileLabel
        '
        Me.ProfileLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfileLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfileLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ProfileLabel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ProfileLabel.Location = New System.Drawing.Point(0, 0)
        Me.ProfileLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfileLabel.Name = "ProfileLabel"
        Me.ProfileLabel.Size = New System.Drawing.Size(154, 24)
        Me.ProfileLabel.TabIndex = 0
        Me.ProfileLabel.Text = "Profiles"
        Me.ProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddProfileBox
        '
        Me.AddProfileBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddProfileBox.Controls.Add(Me.profile_cancel)
        Me.AddProfileBox.Controls.Add(Me.profile_add)
        Me.AddProfileBox.Controls.Add(Me.profile_pass2)
        Me.AddProfileBox.Controls.Add(Me.profile_pass1)
        Me.AddProfileBox.Controls.Add(Me.isProtected)
        Me.AddProfileBox.Controls.Add(Me.isPublic)
        Me.AddProfileBox.Controls.Add(Me.profile_name)
        Me.AddProfileBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddProfileBox.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.AddProfileBox.Location = New System.Drawing.Point(3, 267)
        Me.AddProfileBox.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.AddProfileBox.Name = "AddProfileBox"
        Me.AddProfileBox.Size = New System.Drawing.Size(151, 125)
        Me.AddProfileBox.TabIndex = 2
        Me.AddProfileBox.TabStop = False
        Me.AddProfileBox.Text = "Add Profile"
        '
        'profile_cancel
        '
        Me.profile_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profile_cancel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.profile_cancel.Location = New System.Drawing.Point(91, 99)
        Me.profile_cancel.Name = "profile_cancel"
        Me.profile_cancel.Size = New System.Drawing.Size(53, 22)
        Me.profile_cancel.TabIndex = 6
        Me.profile_cancel.Text = "Cancel"
        Me.profile_cancel.UseVisualStyleBackColor = True
        '
        'profile_add
        '
        Me.profile_add.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.profile_add.Location = New System.Drawing.Point(5, 99)
        Me.profile_add.Name = "profile_add"
        Me.profile_add.Size = New System.Drawing.Size(53, 22)
        Me.profile_add.TabIndex = 5
        Me.profile_add.Tag = "-1"
        Me.profile_add.Text = "Add"
        Me.profile_add.UseVisualStyleBackColor = True
        '
        'profile_pass2
        '
        Me.profile_pass2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profile_pass2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.profile_pass2.Enabled = False
        Me.profile_pass2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.profile_pass2.ForeColor = System.Drawing.Color.Gray
        Me.profile_pass2.Location = New System.Drawing.Point(5, 76)
        Me.profile_pass2.Name = "profile_pass2"
        Me.profile_pass2.Size = New System.Drawing.Size(139, 22)
        Me.profile_pass2.TabIndex = 4
        Me.profile_pass2.Text = "Retype Password"
        '
        'profile_pass1
        '
        Me.profile_pass1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profile_pass1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.profile_pass1.Enabled = False
        Me.profile_pass1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.profile_pass1.ForeColor = System.Drawing.Color.Gray
        Me.profile_pass1.Location = New System.Drawing.Point(5, 55)
        Me.profile_pass1.Name = "profile_pass1"
        Me.profile_pass1.Size = New System.Drawing.Size(139, 22)
        Me.profile_pass1.TabIndex = 3
        Me.profile_pass1.Text = "Set a Password"
        '
        'isProtected
        '
        Me.isProtected.AutoSize = True
        Me.isProtected.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.isProtected.Location = New System.Drawing.Point(70, 37)
        Me.isProtected.Name = "isProtected"
        Me.isProtected.Size = New System.Drawing.Size(74, 17)
        Me.isProtected.TabIndex = 2
        Me.isProtected.Text = "Protected"
        Me.isProtected.UseVisualStyleBackColor = True
        '
        'isPublic
        '
        Me.isPublic.AutoSize = True
        Me.isPublic.Checked = True
        Me.isPublic.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.isPublic.Location = New System.Drawing.Point(5, 37)
        Me.isPublic.Name = "isPublic"
        Me.isPublic.Size = New System.Drawing.Size(56, 17)
        Me.isPublic.TabIndex = 1
        Me.isPublic.TabStop = True
        Me.isPublic.Text = "Public"
        Me.isPublic.UseVisualStyleBackColor = True
        '
        'profile_name
        '
        Me.profile_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profile_name.BackColor = System.Drawing.Color.Snow
        Me.profile_name.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.profile_name.ForeColor = System.Drawing.Color.Gray
        Me.profile_name.Location = New System.Drawing.Point(5, 15)
        Me.profile_name.Name = "profile_name"
        Me.profile_name.Size = New System.Drawing.Size(139, 22)
        Me.profile_name.TabIndex = 0
        Me.profile_name.Text = "Profile Name"
        '
        'ProfileList
        '
        Me.ProfileList.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ProfileList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProfileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch1, Me.ch2})
        Me.ProfileList.ContextMenuStrip = Me.ProfileContext
        Me.ProfileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfileList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProfileList.FullRowSelect = True
        ListViewGroup1.Header = "Public"
        ListViewGroup1.Name = "public"
        ListViewGroup2.Header = "Protected"
        ListViewGroup2.Name = "protected"
        ListViewGroup3.Header = "External"
        ListViewGroup3.Name = "external"
        Me.ProfileList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ProfileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ProfileList.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.UseItemStyleForSubItems = False
        ListViewItem2.Group = ListViewGroup2
        ListViewItem3.Group = ListViewGroup3
        Me.ProfileList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ProfileList.LargeImageList = Me.DefImageList
        Me.ProfileList.Location = New System.Drawing.Point(4, 27)
        Me.ProfileList.Margin = New System.Windows.Forms.Padding(4, 3, 3, 3)
        Me.ProfileList.Name = "ProfileList"
        Me.ProfileList.ShowItemToolTips = True
        Me.ProfileList.Size = New System.Drawing.Size(147, 237)
        Me.ProfileList.SmallImageList = Me.DefImageList
        Me.ProfileList.TabIndex = 1
        Me.ProfileList.UseCompatibleStateImageBehavior = False
        Me.ProfileList.View = System.Windows.Forms.View.Details
        '
        'ch1
        '
        Me.ch1.Text = "Profile name"
        Me.ch1.Width = 87
        '
        'ch2
        '
        Me.ch2.Text = "Type"
        '
        'ProfileContext
        '
        Me.ProfileContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.SetAsDefaultTool1, Me.AddNewProfileToolStripMenuItem, Me.ToolStripSeparator4, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.ToolStripSeparator6, Me.SettingsToolStripMenuItem1})
        Me.ProfileContext.Name = "ProfileContext"
        Me.ProfileContext.Size = New System.Drawing.Size(161, 148)
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        Me.EditProfileToolStripMenuItem.Visible = False
        '
        'SetAsDefaultTool1
        '
        Me.SetAsDefaultTool1.Name = "SetAsDefaultTool1"
        Me.SetAsDefaultTool1.Size = New System.Drawing.Size(160, 22)
        Me.SetAsDefaultTool1.Text = "Set As Default"
        Me.SetAsDefaultTool1.Visible = False
        '
        'AddNewProfileToolStripMenuItem
        '
        Me.AddNewProfileToolStripMenuItem.Name = "AddNewProfileToolStripMenuItem"
        Me.AddNewProfileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddNewProfileToolStripMenuItem.Text = "Add New Profile"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(157, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        Me.DeleteToolStripMenuItem1.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(157, 6)
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'AddressLayoutPanel
        '
        Me.AddressLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLayoutPanel.ColumnCount = 1
        Me.AddressLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AddressLayoutPanel.Controls.Add(Me.AddressList, 0, 1)
        Me.AddressLayoutPanel.Controls.Add(Me.Group1, 0, 2)
        Me.AddressLayoutPanel.Controls.Add(Me.panel1, 0, 0)
        Me.AddressLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressLayoutPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.AddressLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddressLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.AddressLayoutPanel.Name = "AddressLayoutPanel"
        Me.AddressLayoutPanel.RowCount = 3
        Me.AddressLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.AddressLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AddressLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.AddressLayoutPanel.Size = New System.Drawing.Size(348, 392)
        Me.AddressLayoutPanel.TabIndex = 5
        '
        'AddressList
        '
        Me.AddressList.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.AddressList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2, Me.columnHeader4})
        Me.AddressList.ContextMenuStrip = Me.AddressContext
        Me.AddressList.DataBindings.Add(New System.Windows.Forms.Binding("ShowGroups", Global.Web_Address_Book.My.MySettings.Default, "showGroup", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AddressList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddressList.FullRowSelect = True
        Me.AddressList.GridLines = True
        Me.AddressList.HideSelection = False
        Me.AddressList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.AddressList.LargeImageList = Me.LargeImageList
        Me.AddressList.Location = New System.Drawing.Point(0, 33)
        Me.AddressList.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.AddressList.MultiSelect = False
        Me.AddressList.Name = "AddressList"
        Me.AddressList.ShowGroups = Global.Web_Address_Book.My.MySettings.Default.showGroup
        Me.AddressList.ShowItemToolTips = True
        Me.AddressList.Size = New System.Drawing.Size(345, 231)
        Me.AddressList.SmallImageList = Me.SmallImageList
        Me.AddressList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AddressList.TabIndex = 1
        Me.AddressList.Tag = ""
        Me.AddressList.TileSize = New System.Drawing.Size(160, 34)
        Me.AddressList.UseCompatibleStateImageBehavior = False
        Me.AddressList.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Info"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address"
        Me.ColumnHeader2.Width = 180
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Priority"
        '
        'AddressContext
        '
        Me.AddressContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenURLToolStripMenuItem, Me.CopyURLToolStripMenuItem, Me.viewAsToolStripMenuItem, Me.sortByToolStripMenuItem, Me.ToolStripSeparator1, Me.EditToolStripMenuItem, Me.saveIconMenuItm, Me.ToolStripSeparator2, Me.ShowGroupToolStripMenuItem, Me.ToolStripSeparator3, Me.AddNewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.refreshToolStripMenuItem})
        Me.AddressContext.Name = "ContextMenuStrip1"
        Me.AddressContext.Size = New System.Drawing.Size(145, 242)
        '
        'OpenURLToolStripMenuItem
        '
        Me.OpenURLToolStripMenuItem.Name = "OpenURLToolStripMenuItem"
        Me.OpenURLToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpenURLToolStripMenuItem.Text = "&Open URL"
        Me.OpenURLToolStripMenuItem.Visible = False
        '
        'CopyURLToolStripMenuItem
        '
        Me.CopyURLToolStripMenuItem.Name = "CopyURLToolStripMenuItem"
        Me.CopyURLToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyURLToolStripMenuItem.Text = "&Copy URL"
        Me.CopyURLToolStripMenuItem.Visible = False
        '
        'viewAsToolStripMenuItem
        '
        Me.viewAsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tiledToolStripMenuItem, Me.detailsToolStripMenuItem, Me.smallIconToolStripMenuItem})
        Me.viewAsToolStripMenuItem.Name = "viewAsToolStripMenuItem"
        Me.viewAsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.viewAsToolStripMenuItem.Text = "View As"
        '
        'tiledToolStripMenuItem
        '
        Me.tiledToolStripMenuItem.Checked = True
        Me.tiledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tiledToolStripMenuItem.Name = "tiledToolStripMenuItem"
        Me.tiledToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.tiledToolStripMenuItem.Text = "Tiled"
        '
        'detailsToolStripMenuItem
        '
        Me.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem"
        Me.detailsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.detailsToolStripMenuItem.Text = "Details"
        '
        'smallIconToolStripMenuItem
        '
        Me.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem"
        Me.smallIconToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.smallIconToolStripMenuItem.Text = "Small Icon"
        '
        'sortByToolStripMenuItem
        '
        Me.sortByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nameToolStripMenuItem, Me.uRLToolStripMenuItem, Me.priorityToolStripMenuItem, Me.toolStripSeparator5, Me.ascndingToolStripMenuItem, Me.descendingToolStripMenuItem})
        Me.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem"
        Me.sortByToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.sortByToolStripMenuItem.Text = "Sort By"
        '
        'nameToolStripMenuItem
        '
        Me.nameToolStripMenuItem.Checked = True
        Me.nameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.nameToolStripMenuItem.Name = "nameToolStripMenuItem"
        Me.nameToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.nameToolStripMenuItem.Text = "Name"
        '
        'uRLToolStripMenuItem
        '
        Me.uRLToolStripMenuItem.Name = "uRLToolStripMenuItem"
        Me.uRLToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.uRLToolStripMenuItem.Text = "URL"
        '
        'priorityToolStripMenuItem
        '
        Me.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem"
        Me.priorityToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.priorityToolStripMenuItem.Text = "Priority"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(133, 6)
        '
        'ascndingToolStripMenuItem
        '
        Me.ascndingToolStripMenuItem.Checked = True
        Me.ascndingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ascndingToolStripMenuItem.Name = "ascndingToolStripMenuItem"
        Me.ascndingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ascndingToolStripMenuItem.Text = "Ascending"
        '
        'descendingToolStripMenuItem
        '
        Me.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem"
        Me.descendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.descendingToolStripMenuItem.Text = "Descending"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.Visible = False
        '
        'saveIconMenuItm
        '
        Me.saveIconMenuItm.Name = "saveIconMenuItm"
        Me.saveIconMenuItm.Size = New System.Drawing.Size(144, 22)
        Me.saveIconMenuItm.Text = "Save Icon"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'ShowGroupToolStripMenuItem
        '
        Me.ShowGroupToolStripMenuItem.Name = "ShowGroupToolStripMenuItem"
        Me.ShowGroupToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ShowGroupToolStripMenuItem.Text = "Show Groups"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewToolStripMenuItem.ShowShortcutKeys = False
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddNewToolStripMenuItem.Text = "Add &New Item"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        Me.DeleteToolStripMenuItem.Visible = False
        '
        'refreshToolStripMenuItem
        '
        Me.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem"
        Me.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.refreshToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.refreshToolStripMenuItem.Text = "Refresh"
        '
        'LargeImageList
        '
        Me.LargeImageList.ImageStream = CType(resources.GetObject("LargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.LargeImageList.Images.SetKeyName(0, "default")
        '
        'SmallImageList
        '
        Me.SmallImageList.ImageStream = CType(resources.GetObject("SmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallImageList.Images.SetKeyName(0, "default")
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Group1.Controls.Add(Me.web_group)
        Me.Group1.Controls.Add(Me.web_img)
        Me.Group1.Controls.Add(Me.web_cancel)
        Me.Group1.Controls.Add(Me.web_add)
        Me.Group1.Controls.Add(Me.web_info)
        Me.Group1.Controls.Add(Me.web_url)
        Me.Group1.Controls.Add(Me.web_name)
        Me.Group1.Controls.Add(Me.web_priority)
        Me.Group1.Controls.Add(Me.GroupLabel2)
        Me.Group1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Group1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Group1.Location = New System.Drawing.Point(0, 267)
        Me.Group1.Margin = New System.Windows.Forms.Padding(0)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(348, 125)
        Me.Group1.TabIndex = 2
        Me.Group1.TabStop = False
        Me.Group1.Text = "Add New URL"
        '
        'web_group
        '
        Me.web_group.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.web_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.web_group.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.web_group.DropDownHeight = 240
        Me.web_group.DropDownWidth = 150
        Me.web_group.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.web_group.IntegralHeight = False
        Me.web_group.Location = New System.Drawing.Point(50, 98)
        Me.web_group.Name = "web_group"
        Me.web_group.Size = New System.Drawing.Size(187, 23)
        Me.web_group.Sorted = True
        Me.web_group.TabIndex = 8
        Me.web_group.Text = "Default"
        '
        'web_img
        '
        Me.web_img.BackColor = System.Drawing.Color.Transparent
        Me.web_img.BackgroundImage = CType(resources.GetObject("web_img.BackgroundImage"), System.Drawing.Image)
        Me.web_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.web_img.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.web_img.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.web_img.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.web_img.Location = New System.Drawing.Point(4, 59)
        Me.web_img.Name = "web_img"
        Me.web_img.Size = New System.Drawing.Size(44, 38)
        Me.web_img.TabIndex = 4
        Me.web_img.Tag = "0"
        Me.web_img.UseVisualStyleBackColor = False
        '
        'web_cancel
        '
        Me.web_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_cancel.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.web_cancel.Location = New System.Drawing.Point(297, 99)
        Me.web_cancel.Name = "web_cancel"
        Me.web_cancel.Size = New System.Drawing.Size(50, 22)
        Me.web_cancel.TabIndex = 10
        Me.web_cancel.Text = "Cancel"
        Me.web_cancel.UseVisualStyleBackColor = True
        '
        'web_add
        '
        Me.web_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_add.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.web_add.Location = New System.Drawing.Point(243, 99)
        Me.web_add.Name = "web_add"
        Me.web_add.Size = New System.Drawing.Size(50, 22)
        Me.web_add.TabIndex = 9
        Me.web_add.Text = "Add"
        Me.web_add.UseVisualStyleBackColor = True
        '
        'web_info
        '
        Me.web_info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.web_info.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.web_info.ForeColor = System.Drawing.Color.Gray
        Me.web_info.Location = New System.Drawing.Point(50, 60)
        Me.web_info.Multiline = True
        Me.web_info.Name = "web_info"
        Me.web_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.web_info.Size = New System.Drawing.Size(296, 36)
        Me.web_info.TabIndex = 6
        Me.web_info.Text = "Short Info"
        '
        'web_url
        '
        Me.web_url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_url.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.web_url.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!)
        Me.web_url.ForeColor = System.Drawing.Color.Navy
        Me.web_url.Location = New System.Drawing.Point(5, 14)
        Me.web_url.Name = "web_url"
        Me.web_url.Size = New System.Drawing.Size(341, 22)
        Me.web_url.TabIndex = 0
        Me.web_url.Tag = "0"
        Me.web_url.Text = "http://"
        '
        'web_name
        '
        Me.web_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.web_name.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Italic)
        Me.web_name.ForeColor = System.Drawing.Color.Gray
        Me.web_name.Location = New System.Drawing.Point(5, 37)
        Me.web_name.Name = "web_name"
        Me.web_name.Size = New System.Drawing.Size(232, 22)
        Me.web_name.TabIndex = 2
        Me.web_name.Tag = "0"
        Me.web_name.Text = "Website name"
        '
        'web_priority
        '
        Me.web_priority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web_priority.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.web_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.web_priority.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.web_priority.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.web_priority.Items.AddRange(New Object() {"Low", "Below Normal", "Normal", "Above Normal", "High"})
        Me.web_priority.Location = New System.Drawing.Point(242, 37)
        Me.web_priority.MaxDropDownItems = 7
        Me.web_priority.Name = "web_priority"
        Me.web_priority.Size = New System.Drawing.Size(104, 21)
        Me.web_priority.TabIndex = 3
        '
        'GroupLabel2
        '
        Me.GroupLabel2.AutoSize = True
        Me.GroupLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupLabel2.ForeColor = System.Drawing.Color.Black
        Me.GroupLabel2.Location = New System.Drawing.Point(5, 102)
        Me.GroupLabel2.Name = "GroupLabel2"
        Me.GroupLabel2.Size = New System.Drawing.Size(49, 13)
        Me.GroupLabel2.TabIndex = 7
        Me.GroupLabel2.Text = "Group : "
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.removeSearchString)
        Me.panel1.Controls.Add(Me.searchBox)
        Me.panel1.Controls.Add(Me.ShowProfileButton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 3)
        Me.panel1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(345, 27)
        Me.panel1.TabIndex = 0
        '
        'removeSearchString
        '
        Me.removeSearchString.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.removeSearchString.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.removeSearchString.BackgroundImage = Global.Web_Address_Book.My.Resources.Resources.Delete
        Me.removeSearchString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.removeSearchString.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.removeSearchString.FlatAppearance.BorderSize = 0
        Me.removeSearchString.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.removeSearchString.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.removeSearchString.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeSearchString.Location = New System.Drawing.Point(322, 2)
        Me.removeSearchString.Name = "removeSearchString"
        Me.removeSearchString.Size = New System.Drawing.Size(22, 22)
        Me.removeSearchString.TabIndex = 2
        Me.removeSearchString.UseVisualStyleBackColor = False
        Me.removeSearchString.Visible = False
        '
        'searchBox
        '
        Me.searchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.searchBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.searchBox.ForeColor = System.Drawing.Color.Teal
        Me.searchBox.Location = New System.Drawing.Point(20, 0)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(0)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(325, 25)
        Me.searchBox.TabIndex = 1
        Me.searchBox.Text = "Quick Search"
        '
        'ShowProfileButton
        '
        Me.ShowProfileButton.BackColor = System.Drawing.Color.Lavender
        Me.ShowProfileButton.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.Web_Address_Book.My.MySettings.Default, "sp1p1c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ShowProfileButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ShowProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowProfileButton.FlatAppearance.BorderSize = 0
        Me.ShowProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowProfileButton.ImageKey = "show"
        Me.ShowProfileButton.ImageList = Me.DefImageList
        Me.ShowProfileButton.Location = New System.Drawing.Point(0, 0)
        Me.ShowProfileButton.Name = "ShowProfileButton"
        Me.ShowProfileButton.Size = New System.Drawing.Size(20, 27)
        Me.ShowProfileButton.TabIndex = 0
        Me.ShowProfileButton.UseVisualStyleBackColor = False
        Me.ShowProfileButton.Visible = Global.Web_Address_Book.My.MySettings.Default.sp1p1c
        '
        'TopPanel
        '
        Me.TopPanel.BackgroundImage = Global.Web_Address_Book.My.Resources.Resources.gradiantBlack
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(504, 50)
        Me.TopPanel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Web_Address_Book.My.Resources.Resources.adb
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Global.Web_Address_Book.My.MySettings.Default.formSize
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TopPanel)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.Web_Address_Book.My.MySettings.Default, "formSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Address Book"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ProfileLayoutPanel.ResumeLayout(False)
        Me.ProfilePanel.ResumeLayout(False)
        Me.AddProfileBox.ResumeLayout(False)
        Me.AddProfileBox.PerformLayout()
        Me.ProfileContext.ResumeLayout(False)
        Me.AddressLayoutPanel.ResumeLayout(False)
        Me.AddressContext.ResumeLayout(False)
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ProfilePanel As System.Windows.Forms.Panel
    Friend WithEvents ProfileLabel As System.Windows.Forms.Label
    Friend WithEvents ProfileLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AddProfileBox As System.Windows.Forms.GroupBox
    Friend WithEvents profile_name As System.Windows.Forms.TextBox
    Friend WithEvents isProtected As System.Windows.Forms.RadioButton
    Friend WithEvents isPublic As System.Windows.Forms.RadioButton
    Friend WithEvents profile_pass2 As System.Windows.Forms.TextBox
    Friend WithEvents profile_pass1 As System.Windows.Forms.TextBox
    Friend WithEvents profile_add As System.Windows.Forms.Button
    Friend WithEvents profile_cancel As System.Windows.Forms.Button
    Friend WithEvents ProfileList As System.Windows.Forms.ListView
    Friend WithEvents ch1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DefImageList As System.Windows.Forms.ImageList
    Friend WithEvents AddressLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AddressList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddressContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents viewAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tiledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents detailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents smallIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents sortByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents nameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents uRLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents priorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ascndingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents descendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveIconMenuItm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents refreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Group1 As System.Windows.Forms.GroupBox
    Friend WithEvents web_group As System.Windows.Forms.ComboBox
    Private WithEvents web_img As System.Windows.Forms.Button
    Friend WithEvents web_cancel As System.Windows.Forms.Button
    Friend WithEvents web_add As System.Windows.Forms.Button
    Friend WithEvents web_info As System.Windows.Forms.TextBox
    Friend WithEvents web_url As System.Windows.Forms.TextBox
    Friend WithEvents web_name As System.Windows.Forms.TextBox
    Private WithEvents web_priority As System.Windows.Forms.ComboBox
    Friend WithEvents GroupLabel2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents removeSearchString As System.Windows.Forms.Button
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents HideProfileButton As System.Windows.Forms.Button
    Friend WithEvents ShowProfileButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SmallImageList As System.Windows.Forms.ImageList
    Friend WithEvents LargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ProfileContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsDefaultTool1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
