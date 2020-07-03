<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xplore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xplore))
        Me.des3 = New System.Windows.Forms.ProgressBar()
        Me.mail_img = New System.Windows.Forms.PictureBox()
        Me.mov_name = New System.Windows.Forms.Label()
        Me.vifarnet = New System.Windows.Forms.Label()
        Me.intro1 = New System.Windows.Forms.Label()
        Me.srch = New System.Windows.Forms.Button()
        Me.srchbox = New System.Windows.Forms.TextBox()
        Me.des7 = New System.Windows.Forms.ProgressBar()
        Me.label = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_name = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_arr = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_hlpsupp = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_abt = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_gotostrtpage = New System.Windows.Forms.ToolStripMenuItem()
        Me.gotostrtpage_txt = New System.Windows.Forms.ToolStripMenuItem()
        Me.Xit = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_rfsh = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtsresrv = New System.Windows.Forms.Label()
        Me.VifCorp = New System.Windows.Forms.Label()
        Me.srchr = New System.DirectoryServices.DirectorySearcher()
        Me.year = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.res = New System.Windows.Forms.ListBox()
        Me.cnt1 = New System.Windows.Forms.Label()
        CType(Me.mail_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'des3
        '
        Me.des3.Location = New System.Drawing.Point(-14, 108)
        Me.des3.MarqueeAnimationSpeed = 8
        Me.des3.Name = "des3"
        Me.des3.Size = New System.Drawing.Size(1407, 10)
        Me.des3.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des3.TabIndex = 103
        '
        'mail_img
        '
        Me.mail_img.BackColor = System.Drawing.Color.Transparent
        Me.mail_img.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.mail_img.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xplore
        Me.mail_img.Location = New System.Drawing.Point(12, 30)
        Me.mail_img.Name = "mail_img"
        Me.mail_img.Size = New System.Drawing.Size(77, 72)
        Me.mail_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mail_img.TabIndex = 97
        Me.mail_img.TabStop = False
        '
        'mov_name
        '
        Me.mov_name.AutoSize = True
        Me.mov_name.BackColor = System.Drawing.Color.Transparent
        Me.mov_name.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mov_name.ForeColor = System.Drawing.Color.White
        Me.mov_name.Location = New System.Drawing.Point(90, 51)
        Me.mov_name.Name = "mov_name"
        Me.mov_name.Size = New System.Drawing.Size(138, 56)
        Me.mov_name.TabIndex = 99
        Me.mov_name.Text = "Xplore!"
        '
        'vifarnet
        '
        Me.vifarnet.AutoSize = True
        Me.vifarnet.BackColor = System.Drawing.Color.Transparent
        Me.vifarnet.Font = New System.Drawing.Font("Baskerville Old Face", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vifarnet.ForeColor = System.Drawing.Color.Tomato
        Me.vifarnet.Location = New System.Drawing.Point(93, 26)
        Me.vifarnet.Name = "vifarnet"
        Me.vifarnet.Size = New System.Drawing.Size(122, 38)
        Me.vifarnet.TabIndex = 98
        Me.vifarnet.Text = "Vifarnet"
        '
        'intro1
        '
        Me.intro1.AutoSize = True
        Me.intro1.BackColor = System.Drawing.Color.Transparent
        Me.intro1.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro1.ForeColor = System.Drawing.Color.White
        Me.intro1.Location = New System.Drawing.Point(3, 121)
        Me.intro1.Name = "intro1"
        Me.intro1.Size = New System.Drawing.Size(1035, 69)
        Me.intro1.TabIndex = 134
        Me.intro1.Text = resources.GetString("intro1.Text")
        '
        'srch
        '
        Me.srch.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xplore
        Me.srch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.srch.Location = New System.Drawing.Point(573, 250)
        Me.srch.Name = "srch"
        Me.srch.Size = New System.Drawing.Size(201, 50)
        Me.srch.TabIndex = 136
        Me.srch.Text = "Begin the search!"
        Me.srch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.srch.UseVisualStyleBackColor = True
        '
        'srchbox
        '
        Me.srchbox.AcceptsReturn = True
        Me.srchbox.BackColor = System.Drawing.Color.White
        Me.srchbox.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchbox.Location = New System.Drawing.Point(261, 205)
        Me.srchbox.Name = "srchbox"
        Me.srchbox.Size = New System.Drawing.Size(812, 39)
        Me.srchbox.TabIndex = 135
        '
        'des7
        '
        Me.des7.Location = New System.Drawing.Point(261, 241)
        Me.des7.MarqueeAnimationSpeed = 8
        Me.des7.Name = "des7"
        Me.des7.Size = New System.Drawing.Size(812, 3)
        Me.des7.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des7.TabIndex = 138
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.White
        Me.label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.label.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.label.Location = New System.Drawing.Point(538, 208)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(261, 31)
        Me.label.TabIndex = 139
        Me.label.Text = "Type your search here..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(261, 205)
        Me.ProgressBar1.MarqueeAnimationSpeed = 8
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(812, 3)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 140
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg11
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_name, Me.m_arr, Me.m_hlpsupp, Me.m_abt, Me.m_gotostrtpage, Me.m_rfsh})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1340, 24)
        Me.MenuStrip1.TabIndex = 141
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_name
        '
        Me.m_name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_name.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xplore
        Me.m_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.m_name.Name = "m_name"
        Me.m_name.ShowShortcutKeys = False
        Me.m_name.Size = New System.Drawing.Size(70, 20)
        Me.m_name.Text = "MENU"
        Me.m_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm_arr
        '
        Me.m_arr.Enabled = False
        Me.m_arr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_arr.Name = "m_arr"
        Me.m_arr.Size = New System.Drawing.Size(51, 20)
        Me.m_arr.Text = ">>>>"
        Me.m_arr.Visible = False
        '
        'm_hlpsupp
        '
        Me.m_hlpsupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.m_hlpsupp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_hlpsupp.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.help
        Me.m_hlpsupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_hlpsupp.ImageTransparentColor = System.Drawing.Color.White
        Me.m_hlpsupp.Name = "m_hlpsupp"
        Me.m_hlpsupp.ShowShortcutKeys = False
        Me.m_hlpsupp.Size = New System.Drawing.Size(118, 20)
        Me.m_hlpsupp.Text = "Help && Support"
        Me.m_hlpsupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_hlpsupp.Visible = False
        '
        'm_abt
        '
        Me.m_abt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_abt.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.info
        Me.m_abt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_abt.Name = "m_abt"
        Me.m_abt.Size = New System.Drawing.Size(68, 20)
        Me.m_abt.Text = "About"
        Me.m_abt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_abt.Visible = False
        '
        'm_gotostrtpage
        '
        Me.m_gotostrtpage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gotostrtpage_txt, Me.Xit})
        Me.m_gotostrtpage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_gotostrtpage.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.arrow5
        Me.m_gotostrtpage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_gotostrtpage.Name = "m_gotostrtpage"
        Me.m_gotostrtpage.Size = New System.Drawing.Size(63, 20)
        Me.m_gotostrtpage.Text = "More"
        Me.m_gotostrtpage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.m_gotostrtpage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.m_gotostrtpage.Visible = False
        '
        'gotostrtpage_txt
        '
        Me.gotostrtpage_txt.BackColor = System.Drawing.Color.White
        Me.gotostrtpage_txt.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xplr
        Me.gotostrtpage_txt.Name = "gotostrtpage_txt"
        Me.gotostrtpage_txt.Size = New System.Drawing.Size(175, 22)
        Me.gotostrtpage_txt.Text = "Vifarnet Main Page"
        '
        'Xit
        '
        Me.Xit.BackColor = System.Drawing.Color.White
        Me.Xit.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close1
        Me.Xit.Name = "Xit"
        Me.Xit.Size = New System.Drawing.Size(175, 22)
        Me.Xit.Text = "Exit Vifarnet"
        '
        'm_rfsh
        '
        Me.m_rfsh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.m_rfsh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rfsh.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.refresh
        Me.m_rfsh.Name = "m_rfsh"
        Me.m_rfsh.Size = New System.Drawing.Size(122, 20)
        Me.m_rfsh.Text = "Refresh Window"
        Me.m_rfsh.Visible = False
        '
        'rtsresrv
        '
        Me.rtsresrv.AutoSize = True
        Me.rtsresrv.BackColor = System.Drawing.Color.Transparent
        Me.rtsresrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtsresrv.ForeColor = System.Drawing.Color.White
        Me.rtsresrv.Location = New System.Drawing.Point(1188, 676)
        Me.rtsresrv.Name = "rtsresrv"
        Me.rtsresrv.Size = New System.Drawing.Size(152, 20)
        Me.rtsresrv.TabIndex = 144
        Me.rtsresrv.Text = "All Rights Reserved."
        '
        'VifCorp
        '
        Me.VifCorp.AutoSize = True
        Me.VifCorp.BackColor = System.Drawing.Color.Transparent
        Me.VifCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VifCorp.ForeColor = System.Drawing.Color.White
        Me.VifCorp.Location = New System.Drawing.Point(1131, 656)
        Me.VifCorp.Name = "VifCorp"
        Me.VifCorp.Size = New System.Drawing.Size(211, 20)
        Me.VifCorp.TabIndex = 143
        Me.VifCorp.Text = "© 2012 Vifarnet Corporation "
        '
        'srchr
        '
        Me.srchr.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.srchr.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.srchr.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.Font = New System.Drawing.Font("Pristina", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.year.Location = New System.Drawing.Point(1282, 605)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(56, 32)
        Me.year.TabIndex = 145
        Me.year.Text = "2012"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Pristina", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label3.Location = New System.Drawing.Point(1154, 612)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 44)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "X-emplar"
        '
        'res
        '
        Me.res.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res.FormattingEnabled = True
        Me.res.ItemHeight = 22
        Me.res.Location = New System.Drawing.Point(261, 312)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(812, 334)
        Me.res.TabIndex = 147
        '
        'cnt1
        '
        Me.cnt1.AutoSize = True
        Me.cnt1.BackColor = System.Drawing.Color.Transparent
        Me.cnt1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnt1.ForeColor = System.Drawing.Color.White
        Me.cnt1.Location = New System.Drawing.Point(257, 286)
        Me.cnt1.Name = "cnt1"
        Me.cnt1.Size = New System.Drawing.Size(153, 26)
        Me.cnt1.TabIndex = 148
        Me.cnt1.Text = "Ready to search"
        '
        'xplore
        '
        Me.AcceptButton = Me.srch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1340, 705)
        Me.Controls.Add(Me.cnt1)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtsresrv)
        Me.Controls.Add(Me.VifCorp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.des7)
        Me.Controls.Add(Me.srch)
        Me.Controls.Add(Me.srchbox)
        Me.Controls.Add(Me.intro1)
        Me.Controls.Add(Me.des3)
        Me.Controls.Add(Me.vifarnet)
        Me.Controls.Add(Me.mov_name)
        Me.Controls.Add(Me.mail_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "xplore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Xplore!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mail_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents des3 As System.Windows.Forms.ProgressBar
    Friend WithEvents mail_img As System.Windows.Forms.PictureBox
    Friend WithEvents mov_name As System.Windows.Forms.Label
    Friend WithEvents vifarnet As System.Windows.Forms.Label
    Friend WithEvents intro1 As System.Windows.Forms.Label
    Friend WithEvents srch As System.Windows.Forms.Button
    Friend WithEvents srchbox As System.Windows.Forms.TextBox
    Friend WithEvents des7 As System.Windows.Forms.ProgressBar
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_name As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_arr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_hlpsupp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_abt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_gotostrtpage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gotostrtpage_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Xit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_rfsh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtsresrv As System.Windows.Forms.Label
    Friend WithEvents VifCorp As System.Windows.Forms.Label
    Friend WithEvents srchr As System.DirectoryServices.DirectorySearcher
    Friend WithEvents year As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents res As System.Windows.Forms.ListBox
    Friend WithEvents cnt1 As System.Windows.Forms.Label
End Class
