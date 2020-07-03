<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VifFixIt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VifFixIt))
        Me.fixit_name = New System.Windows.Forms.Label()
        Me.vifarnet = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        Me.fixit_logo = New System.Windows.Forms.PictureBox()
        Me.bar = New System.Windows.Forms.PictureBox()
        Me.Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.hlpsup_img = New System.Windows.Forms.PictureBox()
        Me.abt_img = New System.Windows.Forms.PictureBox()
        Me.version = New System.Windows.Forms.Label()
        Me.abt_text = New System.Windows.Forms.Label()
        Me.hlpsup_text = New System.Windows.Forms.Label()
        Me.gotostrtpage_text = New System.Windows.Forms.Label()
        Me.intro1 = New System.Windows.Forms.Label()
        Me.intro2 = New System.Windows.Forms.Label()
        Me.thanks = New System.Windows.Forms.Label()
        Me.wellwish = New System.Windows.Forms.Label()
        Me.srchbox = New System.Windows.Forms.TextBox()
        Me.srch = New System.Windows.Forms.Label()
        Me.srch_nor = New System.Windows.Forms.Button()
        Me.srch_adv = New System.Windows.Forms.Button()
        Me.rtsresrv = New System.Windows.Forms.Label()
        Me.VifCorp = New System.Windows.Forms.Label()
        Me.here = New System.Windows.Forms.PictureBox()
        Me.gotostrtpage_img = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_name = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_arr = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_hlpsupp = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_abt = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_gotostrtpage = New System.Windows.Forms.ToolStripMenuItem()
        Me.gotostrtpage_txt = New System.Windows.Forms.ToolStripMenuItem()
        Me.Xit = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_rfsh = New System.Windows.Forms.ToolStripMenuItem()
        Me.des5 = New System.Windows.Forms.ProgressBar()
        Me.des4 = New System.Windows.Forms.ProgressBar()
        Me.des6 = New System.Windows.Forms.ProgressBar()
        Me.des7 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fixit_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hlpsup_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.abt_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.here, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gotostrtpage_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fixit_name
        '
        Me.fixit_name.AutoSize = True
        Me.fixit_name.BackColor = System.Drawing.Color.Transparent
        Me.fixit_name.Font = New System.Drawing.Font("Harrington", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fixit_name.ForeColor = System.Drawing.Color.SlateBlue
        Me.fixit_name.Location = New System.Drawing.Point(205, 50)
        Me.fixit_name.Name = "fixit_name"
        Me.fixit_name.Size = New System.Drawing.Size(90, 37)
        Me.fixit_name.TabIndex = 7
        Me.fixit_name.Text = "Fix It"
        '
        'vifarnet
        '
        Me.vifarnet.AutoSize = True
        Me.vifarnet.BackColor = System.Drawing.Color.Transparent
        Me.vifarnet.Font = New System.Drawing.Font("Baskerville Old Face", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vifarnet.Location = New System.Drawing.Point(88, 51)
        Me.vifarnet.Name = "vifarnet"
        Me.vifarnet.Size = New System.Drawing.Size(122, 38)
        Me.vifarnet.TabIndex = 6
        Me.vifarnet.Text = "Vifarnet"
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(88, 27)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(103, 22)
        Me.welcome.TabIndex = 4
        Me.welcome.Text = "Welcome to"
        '
        'fixit_logo
        '
        Me.fixit_logo.BackColor = System.Drawing.Color.Transparent
        Me.fixit_logo.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.fixit
        Me.fixit_logo.Location = New System.Drawing.Point(9, 27)
        Me.fixit_logo.Name = "fixit_logo"
        Me.fixit_logo.Size = New System.Drawing.Size(73, 75)
        Me.fixit_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fixit_logo.TabIndex = 5
        Me.fixit_logo.TabStop = False
        '
        'bar
        '
        Me.bar.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.load17
        Me.bar.Location = New System.Drawing.Point(0, 105)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(1371, 5)
        Me.bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bar.TabIndex = 44
        Me.bar.TabStop = False
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'hlpsup_img
        '
        Me.hlpsup_img.BackColor = System.Drawing.Color.Transparent
        Me.hlpsup_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hlpsup_img.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.help1
        Me.hlpsup_img.Location = New System.Drawing.Point(1263, 65)
        Me.hlpsup_img.Name = "hlpsup_img"
        Me.hlpsup_img.Size = New System.Drawing.Size(45, 37)
        Me.hlpsup_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.hlpsup_img.TabIndex = 52
        Me.hlpsup_img.TabStop = False
        '
        'abt_img
        '
        Me.abt_img.BackColor = System.Drawing.Color.Transparent
        Me.abt_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abt_img.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.info
        Me.abt_img.Location = New System.Drawing.Point(1212, 65)
        Me.abt_img.Name = "abt_img"
        Me.abt_img.Size = New System.Drawing.Size(45, 37)
        Me.abt_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.abt_img.TabIndex = 53
        Me.abt_img.TabStop = False
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.BackColor = System.Drawing.Color.Transparent
        Me.version.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.Location = New System.Drawing.Point(290, 51)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(50, 24)
        Me.version.TabIndex = 51
        Me.version.Text = "2012"
        '
        'abt_text
        '
        Me.abt_text.AutoSize = True
        Me.abt_text.BackColor = System.Drawing.Color.White
        Me.abt_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abt_text.Location = New System.Drawing.Point(816, 668)
        Me.abt_text.Name = "abt_text"
        Me.abt_text.Size = New System.Drawing.Size(90, 20)
        Me.abt_text.TabIndex = 54
        Me.abt_text.Text = "About Fix It"
        Me.abt_text.Visible = False
        '
        'hlpsup_text
        '
        Me.hlpsup_text.AutoSize = True
        Me.hlpsup_text.BackColor = System.Drawing.Color.White
        Me.hlpsup_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpsup_text.Location = New System.Drawing.Point(912, 668)
        Me.hlpsup_text.Name = "hlpsup_text"
        Me.hlpsup_text.Size = New System.Drawing.Size(118, 20)
        Me.hlpsup_text.TabIndex = 55
        Me.hlpsup_text.Text = "Help && Support"
        Me.hlpsup_text.Visible = False
        '
        'gotostrtpage_text
        '
        Me.gotostrtpage_text.AutoSize = True
        Me.gotostrtpage_text.BackColor = System.Drawing.Color.White
        Me.gotostrtpage_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotostrtpage_text.Location = New System.Drawing.Point(717, 628)
        Me.gotostrtpage_text.Name = "gotostrtpage_text"
        Me.gotostrtpage_text.Size = New System.Drawing.Size(364, 40)
        Me.gotostrtpage_text.TabIndex = 56
        Me.gotostrtpage_text.Text = "Vifarnet Start Page:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimize all vifarnet windows and go to Start Page."
        Me.gotostrtpage_text.Visible = False
        '
        'intro1
        '
        Me.intro1.AutoSize = True
        Me.intro1.BackColor = System.Drawing.Color.Transparent
        Me.intro1.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro1.Location = New System.Drawing.Point(4, 118)
        Me.intro1.Name = "intro1"
        Me.intro1.Size = New System.Drawing.Size(1331, 69)
        Me.intro1.TabIndex = 57
        Me.intro1.Text = resources.GetString("intro1.Text")
        '
        'intro2
        '
        Me.intro2.AutoSize = True
        Me.intro2.BackColor = System.Drawing.Color.Transparent
        Me.intro2.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro2.Location = New System.Drawing.Point(290, 245)
        Me.intro2.Name = "intro2"
        Me.intro2.Size = New System.Drawing.Size(822, 69)
        Me.intro2.TabIndex = 58
        Me.intro2.Text = resources.GetString("intro2.Text")
        Me.intro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'thanks
        '
        Me.thanks.AutoSize = True
        Me.thanks.BackColor = System.Drawing.Color.Transparent
        Me.thanks.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thanks.Location = New System.Drawing.Point(0, 644)
        Me.thanks.Name = "thanks"
        Me.thanks.Size = New System.Drawing.Size(517, 44)
        Me.thanks.TabIndex = 59
        Me.thanks.Text = "Thank you for your interest in using our product: Vifarnet Fix it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you feel un" & _
            "satisfied, feel free to send us a feedback with your suggestions."
        '
        'wellwish
        '
        Me.wellwish.AutoSize = True
        Me.wellwish.BackColor = System.Drawing.Color.Transparent
        Me.wellwish.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wellwish.Location = New System.Drawing.Point(640, 325)
        Me.wellwish.Name = "wellwish"
        Me.wellwish.Size = New System.Drawing.Size(156, 23)
        Me.wellwish.TabIndex = 60
        Me.wellwish.Text = ":)   Happy Fixing  :) "
        '
        'srchbox
        '
        Me.srchbox.AcceptsReturn = True
        Me.srchbox.BackColor = System.Drawing.Color.White
        Me.srchbox.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchbox.Location = New System.Drawing.Point(294, 387)
        Me.srchbox.Name = "srchbox"
        Me.srchbox.Size = New System.Drawing.Size(812, 39)
        Me.srchbox.TabIndex = 61
        '
        'srch
        '
        Me.srch.AutoSize = True
        Me.srch.BackColor = System.Drawing.Color.White
        Me.srch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.srch.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.srch.Location = New System.Drawing.Point(596, 390)
        Me.srch.Name = "srch"
        Me.srch.Size = New System.Drawing.Size(261, 31)
        Me.srch.TabIndex = 62
        Me.srch.Text = "Type your search here..."
        '
        'srch_nor
        '
        Me.srch_nor.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch_nor.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.srch
        Me.srch_nor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.srch_nor.Location = New System.Drawing.Point(493, 433)
        Me.srch_nor.Name = "srch_nor"
        Me.srch_nor.Size = New System.Drawing.Size(207, 48)
        Me.srch_nor.TabIndex = 63
        Me.srch_nor.Text = "Search for solutions   "
        Me.srch_nor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.srch_nor.UseVisualStyleBackColor = True
        '
        'srch_adv
        '
        Me.srch_adv.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch_adv.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.srch_adv11
        Me.srch_adv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.srch_adv.Location = New System.Drawing.Point(749, 433)
        Me.srch_adv.Name = "srch_adv"
        Me.srch_adv.Size = New System.Drawing.Size(188, 48)
        Me.srch_adv.TabIndex = 64
        Me.srch_adv.Text = "Advanced Search"
        Me.srch_adv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.srch_adv.UseVisualStyleBackColor = True
        '
        'rtsresrv
        '
        Me.rtsresrv.AutoSize = True
        Me.rtsresrv.BackColor = System.Drawing.Color.Transparent
        Me.rtsresrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtsresrv.Location = New System.Drawing.Point(1208, 668)
        Me.rtsresrv.Name = "rtsresrv"
        Me.rtsresrv.Size = New System.Drawing.Size(152, 20)
        Me.rtsresrv.TabIndex = 66
        Me.rtsresrv.Text = "All Rights Reserved."
        '
        'VifCorp
        '
        Me.VifCorp.AutoSize = True
        Me.VifCorp.BackColor = System.Drawing.Color.Transparent
        Me.VifCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VifCorp.Location = New System.Drawing.Point(1151, 648)
        Me.VifCorp.Name = "VifCorp"
        Me.VifCorp.Size = New System.Drawing.Size(211, 20)
        Me.VifCorp.TabIndex = 65
        Me.VifCorp.Text = "© 2012 Vifarnet Corporation "
        '
        'here
        '
        Me.here.BackColor = System.Drawing.Color.Transparent
        Me.here.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.arrow5
        Me.here.Location = New System.Drawing.Point(1096, 630)
        Me.here.Name = "here"
        Me.here.Size = New System.Drawing.Size(27, 38)
        Me.here.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.here.TabIndex = 67
        Me.here.TabStop = False
        Me.here.Visible = False
        '
        'gotostrtpage_img
        '
        Me.gotostrtpage_img.BackColor = System.Drawing.Color.Transparent
        Me.gotostrtpage_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gotostrtpage_img.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.Xemplar
        Me.gotostrtpage_img.Location = New System.Drawing.Point(1314, 65)
        Me.gotostrtpage_img.Name = "gotostrtpage_img"
        Me.gotostrtpage_img.Size = New System.Drawing.Size(45, 37)
        Me.gotostrtpage_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gotostrtpage_img.TabIndex = 85
        Me.gotostrtpage_img.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg4
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_name, Me.m_arr, Me.m_hlpsupp, Me.m_abt, Me.m_gotostrtpage, Me.m_rfsh})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1365, 24)
        Me.MenuStrip1.TabIndex = 86
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_name
        '
        Me.m_name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_name.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.fixit
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
        Me.Xit.Text = "Exit X-emplar"
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
        'des5
        '
        Me.des5.BackColor = System.Drawing.Color.White
        Me.des5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.des5.Location = New System.Drawing.Point(290, 387)
        Me.des5.MarqueeAnimationSpeed = 50
        Me.des5.Name = "des5"
        Me.des5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.des5.Size = New System.Drawing.Size(5, 39)
        Me.des5.Step = 1
        Me.des5.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des5.TabIndex = 87
        Me.des5.Value = 100
        '
        'des4
        '
        Me.des4.BackColor = System.Drawing.Color.White
        Me.des4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.des4.Location = New System.Drawing.Point(1104, 387)
        Me.des4.MarqueeAnimationSpeed = 50
        Me.des4.Name = "des4"
        Me.des4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.des4.Size = New System.Drawing.Size(5, 39)
        Me.des4.Step = 1
        Me.des4.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des4.TabIndex = 90
        Me.des4.Value = 100
        '
        'des6
        '
        Me.des6.Location = New System.Drawing.Point(290, 387)
        Me.des6.MarqueeAnimationSpeed = 8
        Me.des6.Name = "des6"
        Me.des6.Size = New System.Drawing.Size(819, 3)
        Me.des6.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des6.TabIndex = 91
        '
        'des7
        '
        Me.des7.Location = New System.Drawing.Point(290, 424)
        Me.des7.MarqueeAnimationSpeed = 8
        Me.des7.Name = "des7"
        Me.des7.Size = New System.Drawing.Size(819, 3)
        Me.des7.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des7.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Pristina", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(1296, 593)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 32)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "2012"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Pristina", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(1173, 604)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 44)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "X-emplar"
        '
        'VifFixIt
        '
        Me.AcceptButton = Me.srch_nor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 713)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.des7)
        Me.Controls.Add(Me.des6)
        Me.Controls.Add(Me.des4)
        Me.Controls.Add(Me.des5)
        Me.Controls.Add(Me.here)
        Me.Controls.Add(Me.gotostrtpage_img)
        Me.Controls.Add(Me.srch)
        Me.Controls.Add(Me.rtsresrv)
        Me.Controls.Add(Me.VifCorp)
        Me.Controls.Add(Me.srch_adv)
        Me.Controls.Add(Me.srch_nor)
        Me.Controls.Add(Me.srchbox)
        Me.Controls.Add(Me.wellwish)
        Me.Controls.Add(Me.thanks)
        Me.Controls.Add(Me.intro2)
        Me.Controls.Add(Me.vifarnet)
        Me.Controls.Add(Me.gotostrtpage_text)
        Me.Controls.Add(Me.hlpsup_text)
        Me.Controls.Add(Me.abt_img)
        Me.Controls.Add(Me.abt_text)
        Me.Controls.Add(Me.hlpsup_img)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.fixit_name)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.fixit_logo)
        Me.Controls.Add(Me.intro1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1364, 720)
        Me.Name = "VifFixIt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Fix It 2012"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fixit_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hlpsup_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.abt_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.here, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gotostrtpage_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fixit_name As System.Windows.Forms.Label
    Friend WithEvents vifarnet As System.Windows.Forms.Label
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents fixit_logo As System.Windows.Forms.PictureBox
    Friend WithEvents bar As System.Windows.Forms.PictureBox
    Friend WithEvents Info As System.Windows.Forms.ToolTip
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents abt_img As System.Windows.Forms.PictureBox
    Friend WithEvents hlpsup_img As System.Windows.Forms.PictureBox
    Friend WithEvents abt_text As System.Windows.Forms.Label
    Friend WithEvents hlpsup_text As System.Windows.Forms.Label
    Friend WithEvents gotostrtpage_text As System.Windows.Forms.Label
    Friend WithEvents intro1 As System.Windows.Forms.Label
    Friend WithEvents intro2 As System.Windows.Forms.Label
    Friend WithEvents thanks As System.Windows.Forms.Label
    Friend WithEvents wellwish As System.Windows.Forms.Label
    Friend WithEvents srchbox As System.Windows.Forms.TextBox
    Friend WithEvents srch As System.Windows.Forms.Label
    Friend WithEvents srch_nor As System.Windows.Forms.Button
    Friend WithEvents srch_adv As System.Windows.Forms.Button
    Friend WithEvents rtsresrv As System.Windows.Forms.Label
    Friend WithEvents VifCorp As System.Windows.Forms.Label
    Friend WithEvents here As System.Windows.Forms.PictureBox
    Friend WithEvents gotostrtpage_img As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_name As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_hlpsupp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_abt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_gotostrtpage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gotostrtpage_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_rfsh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Xit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_arr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents des5 As System.Windows.Forms.ProgressBar
    Friend WithEvents des4 As System.Windows.Forms.ProgressBar
    Friend WithEvents des6 As System.Windows.Forms.ProgressBar
    Friend WithEvents des7 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
