<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrl))
        Me.rest = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.PictureBox()
        Me.B = New System.Windows.Forms.Panel()
        Me.C = New System.Windows.Forms.PictureBox()
        Me.D = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.opt_music = New System.Windows.Forms.CheckBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.opt_math = New System.Windows.Forms.CheckBox()
        Me.opt_mov = New System.Windows.Forms.CheckBox()
        Me.opt_fixit = New System.Windows.Forms.CheckBox()
        Me.pin_xp = New System.Windows.Forms.CheckBox()
        Me.pin_pvt = New System.Windows.Forms.CheckBox()
        Me.pin_dev = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.opt_xplr = New System.Windows.Forms.CheckBox()
        Me.opt_pin = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shrt = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.up = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.srch = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.l = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        CType(Me.A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.B.SuspendLayout()
        CType(Me.C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.Color.Transparent
        Me.rest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rest.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.rest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rest.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rest.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.Alert
        Me.rest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rest.Location = New System.Drawing.Point(1020, 645)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(254, 37)
        Me.rest.TabIndex = 80
        Me.rest.Text = "Restore default settings to all"
        Me.rest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rest.UseVisualStyleBackColor = False
        '
        'no
        '
        Me.no.BackColor = System.Drawing.Color.Transparent
        Me.no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.no.Cursor = System.Windows.Forms.Cursors.Hand
        Me.no.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.no.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close1
        Me.no.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.no.Location = New System.Drawing.Point(709, 645)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(164, 45)
        Me.no.TabIndex = 64
        Me.no.Text = "Cancel && Close"
        Me.no.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.no.UseVisualStyleBackColor = False
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.Transparent
        Me.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.OK2
        Me.ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ok.Location = New System.Drawing.Point(501, 645)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(169, 45)
        Me.ok.TabIndex = 63
        Me.ok.Text = "Apply Settings"
        Me.ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ok.UseVisualStyleBackColor = False
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.Transparent
        Me.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.A.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.A.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bar
        Me.A.Location = New System.Drawing.Point(-4, 639)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(1383, 75)
        Me.A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.A.TabIndex = 58
        Me.A.TabStop = False
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Transparent
        Me.B.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bar
        Me.B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B.Controls.Add(Me.C)
        Me.B.Controls.Add(Me.D)
        Me.B.Location = New System.Drawing.Point(-4, 0)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(1383, 80)
        Me.B.TabIndex = 57
        '
        'C
        '
        Me.C.BackColor = System.Drawing.Color.Transparent
        Me.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.C.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.settings_5
        Me.C.Location = New System.Drawing.Point(540, 12)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(71, 59)
        Me.C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.C.TabIndex = 8
        Me.C.TabStop = False
        '
        'D
        '
        Me.D.AutoSize = True
        Me.D.BackColor = System.Drawing.Color.Transparent
        Me.D.Font = New System.Drawing.Font("Baskerville Old Face", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D.ForeColor = System.Drawing.Color.White
        Me.D.Location = New System.Drawing.Point(617, 22)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(199, 38)
        Me.D.TabIndex = 9
        Me.D.Text = "Control Panel"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1383, 559)
        Me.ShapeContainer1.TabIndex = 72
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Enabled = False
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 20
        Me.LineShape5.X2 = 43
        Me.LineShape5.Y1 = 343
        Me.LineShape5.Y2 = 343
        '
        'LineShape4
        '
        Me.LineShape4.Enabled = False
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 20
        Me.LineShape4.X2 = 43
        Me.LineShape4.Y1 = 317
        Me.LineShape4.Y2 = 317
        '
        'LineShape3
        '
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 20
        Me.LineShape3.X2 = 43
        Me.LineShape3.Y1 = 291
        Me.LineShape3.Y2 = 291
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 19
        Me.LineShape2.X2 = 19
        Me.LineShape2.Y1 = 271
        Me.LineShape2.Y2 = 343
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.arrow6
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 33)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Start Screen"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(-5, 36)
        Me.ProgressBar2.MarqueeAnimationSpeed = 8
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(201, 5)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar2.TabIndex = 56
        '
        'opt_music
        '
        Me.opt_music.AccessibleName = ""
        Me.opt_music.AutoSize = True
        Me.opt_music.Checked = True
        Me.opt_music.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_music.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_music.Location = New System.Drawing.Point(12, 103)
        Me.opt_music.Name = "opt_music"
        Me.opt_music.Size = New System.Drawing.Size(62, 20)
        Me.opt_music.TabIndex = 57
        Me.opt_music.Text = "Music"
        Me.opt_music.UseVisualStyleBackColor = True
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.l1.Location = New System.Drawing.Point(3, 72)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(63, 28)
        Me.l1.TabIndex = 58
        Me.l1.Text = "Apps"
        '
        'opt_math
        '
        Me.opt_math.AccessibleName = ""
        Me.opt_math.AutoSize = True
        Me.opt_math.Checked = True
        Me.opt_math.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_math.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_math.Location = New System.Drawing.Point(12, 170)
        Me.opt_math.Name = "opt_math"
        Me.opt_math.Size = New System.Drawing.Size(103, 20)
        Me.opt_math.TabIndex = 60
        Me.opt_math.Text = "Mathematics"
        Me.opt_math.UseVisualStyleBackColor = True
        '
        'opt_mov
        '
        Me.opt_mov.AccessibleName = ""
        Me.opt_mov.AutoSize = True
        Me.opt_mov.Checked = True
        Me.opt_mov.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_mov.Location = New System.Drawing.Point(12, 149)
        Me.opt_mov.Name = "opt_mov"
        Me.opt_mov.Size = New System.Drawing.Size(71, 20)
        Me.opt_mov.TabIndex = 61
        Me.opt_mov.Text = "Movies"
        Me.opt_mov.UseVisualStyleBackColor = True
        '
        'opt_fixit
        '
        Me.opt_fixit.AccessibleName = ""
        Me.opt_fixit.AutoSize = True
        Me.opt_fixit.Checked = True
        Me.opt_fixit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_fixit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_fixit.Location = New System.Drawing.Point(12, 126)
        Me.opt_fixit.Name = "opt_fixit"
        Me.opt_fixit.Size = New System.Drawing.Size(53, 20)
        Me.opt_fixit.TabIndex = 62
        Me.opt_fixit.Text = "Fix It"
        Me.opt_fixit.UseVisualStyleBackColor = True
        '
        'pin_xp
        '
        Me.pin_xp.AccessibleName = "checks"
        Me.pin_xp.AutoSize = True
        Me.pin_xp.Checked = True
        Me.pin_xp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pin_xp.Enabled = False
        Me.pin_xp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin_xp.Location = New System.Drawing.Point(44, 334)
        Me.pin_xp.Name = "pin_xp"
        Me.pin_xp.Size = New System.Drawing.Size(87, 20)
        Me.pin_xp.TabIndex = 75
        Me.pin_xp.Text = "Xperiment"
        Me.pin_xp.UseVisualStyleBackColor = True
        '
        'pin_pvt
        '
        Me.pin_pvt.AccessibleName = "checks"
        Me.pin_pvt.AutoSize = True
        Me.pin_pvt.Enabled = False
        Me.pin_pvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin_pvt.Location = New System.Drawing.Point(44, 308)
        Me.pin_pvt.Name = "pin_pvt"
        Me.pin_pvt.Size = New System.Drawing.Size(107, 20)
        Me.pin_pvt.TabIndex = 76
        Me.pin_pvt.Text = "Private Portal"
        Me.pin_pvt.UseVisualStyleBackColor = True
        '
        'pin_dev
        '
        Me.pin_dev.AccessibleName = "checks"
        Me.pin_dev.AutoSize = True
        Me.pin_dev.Enabled = False
        Me.pin_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin_dev.Location = New System.Drawing.Point(44, 282)
        Me.pin_dev.Name = "pin_dev"
        Me.pin_dev.Size = New System.Drawing.Size(117, 20)
        Me.pin_dev.TabIndex = 77
        Me.pin_dev.Text = "Developer Log"
        Me.pin_dev.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(3, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 28)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Pinned"
        '
        'opt_xplr
        '
        Me.opt_xplr.AccessibleName = ""
        Me.opt_xplr.AutoSize = True
        Me.opt_xplr.Checked = True
        Me.opt_xplr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_xplr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_xplr.Location = New System.Drawing.Point(12, 193)
        Me.opt_xplr.Name = "opt_xplr"
        Me.opt_xplr.Size = New System.Drawing.Size(69, 20)
        Me.opt_xplr.TabIndex = 59
        Me.opt_xplr.Text = "Xplore!"
        Me.opt_xplr.UseVisualStyleBackColor = True
        '
        'opt_pin
        '
        Me.opt_pin.AccessibleName = "checks"
        Me.opt_pin.AutoSize = True
        Me.opt_pin.Checked = True
        Me.opt_pin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_pin.Enabled = False
        Me.opt_pin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_pin.Location = New System.Drawing.Point(12, 256)
        Me.opt_pin.Name = "opt_pin"
        Me.opt_pin.Size = New System.Drawing.Size(104, 20)
        Me.opt_pin.TabIndex = 79
        Me.opt_pin.Text = "Pinned Apps"
        Me.opt_pin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(3, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 28)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Shortcuts"
        '
        'shrt
        '
        Me.shrt.AccessibleName = "checks"
        Me.shrt.AutoSize = True
        Me.shrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.shrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shrt.Location = New System.Drawing.Point(12, 414)
        Me.shrt.Name = "shrt"
        Me.shrt.Size = New System.Drawing.Size(110, 20)
        Me.shrt.TabIndex = 81
        Me.shrt.Text = "App Shortcuts"
        Me.shrt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(-2, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 28)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Vifarnet Updates"
        '
        'up
        '
        Me.up.AccessibleName = "checks"
        Me.up.AutoSize = True
        Me.up.Checked = True
        Me.up.CheckState = System.Windows.Forms.CheckState.Checked
        Me.up.Enabled = False
        Me.up.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up.Location = New System.Drawing.Point(12, 496)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(79, 20)
        Me.up.TabIndex = 83
        Me.up.Text = "Updates"
        Me.up.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.arrow6
        Me.PictureBox2.Location = New System.Drawing.Point(240, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 33)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Fix It"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(232, 35)
        Me.ProgressBar1.MarqueeAnimationSpeed = 8
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(201, 5)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 86
        '
        'srch
        '
        Me.srch.AccessibleName = ""
        Me.srch.AutoSize = True
        Me.srch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch.Location = New System.Drawing.Point(240, 102)
        Me.srch.Name = "srch"
        Me.srch.Size = New System.Drawing.Size(135, 20)
        Me.srch.TabIndex = 87
        Me.srch.Text = "Advanced Search"
        Me.srch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(235, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 28)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Search"
        '
        'pb1
        '
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources._error
        Me.pb1.Location = New System.Drawing.Point(240, 182)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(29, 31)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 93
        Me.pb1.TabStop = False
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.BackColor = System.Drawing.Color.Transparent
        Me.l.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.l.Location = New System.Drawing.Point(275, 182)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(92, 33)
        Me.l.TabIndex = 92
        Me.l.Text = "Music"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(232, 212)
        Me.pb.MarqueeAnimationSpeed = 8
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(201, 5)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(234, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 18)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Temporarily Unavailable"
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.pb)
        Me.Panel.Controls.Add(Me.l)
        Me.Panel.Controls.Add(Me.pb1)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.srch)
        Me.Panel.Controls.Add(Me.ProgressBar1)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.PictureBox2)
        Me.Panel.Controls.Add(Me.up)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.shrt)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.opt_pin)
        Me.Panel.Controls.Add(Me.opt_xplr)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.pin_dev)
        Me.Panel.Controls.Add(Me.pin_pvt)
        Me.Panel.Controls.Add(Me.pin_xp)
        Me.Panel.Controls.Add(Me.opt_fixit)
        Me.Panel.Controls.Add(Me.opt_mov)
        Me.Panel.Controls.Add(Me.opt_math)
        Me.Panel.Controls.Add(Me.l1)
        Me.Panel.Controls.Add(Me.opt_music)
        Me.Panel.Controls.Add(Me.ProgressBar2)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Controls.Add(Me.ShapeContainer1)
        Me.Panel.Location = New System.Drawing.Point(0, 80)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1383, 559)
        Me.Panel.TabIndex = 59
        '
        'ctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1286, 715)
        Me.Controls.Add(Me.rest)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.B)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ctrl"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.B.ResumeLayout(False)
        Me.B.PerformLayout()
        CType(Me.C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C As System.Windows.Forms.PictureBox
    Friend WithEvents D As System.Windows.Forms.Label
    Friend WithEvents B As System.Windows.Forms.Panel
    Friend WithEvents A As System.Windows.Forms.PictureBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.Button
    Friend WithEvents rest As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents opt_music As System.Windows.Forms.CheckBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents opt_math As System.Windows.Forms.CheckBox
    Friend WithEvents opt_mov As System.Windows.Forms.CheckBox
    Friend WithEvents opt_fixit As System.Windows.Forms.CheckBox
    Friend WithEvents pin_xp As System.Windows.Forms.CheckBox
    Friend WithEvents pin_pvt As System.Windows.Forms.CheckBox
    Friend WithEvents pin_dev As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents opt_xplr As System.Windows.Forms.CheckBox
    Friend WithEvents opt_pin As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents shrt As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents up As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents srch As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel As System.Windows.Forms.Panel
End Class
