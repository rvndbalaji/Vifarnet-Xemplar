<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vifmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vifmt))
        Me.setname = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.vif = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.change = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.mt_abt = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.book = New System.Windows.Forms.Button()
        Me.des = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.m = New System.Windows.Forms.Timer(Me.components)
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.showMTasks = New System.Windows.Forms.ToolStripMenuItem()
        Me.Xit = New System.Windows.Forms.ToolStripMenuItem()
        Me.booked = New System.Windows.Forms.Button()
        Me.min = New System.Windows.Forms.PictureBox()
        Me.xitmt = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrayMenu.SuspendLayout()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xitmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'setname
        '
        Me.setname.BackColor = System.Drawing.Color.Transparent
        Me.setname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.setname.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setname.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.admin
        Me.setname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.setname.Location = New System.Drawing.Point(760, 103)
        Me.setname.Name = "setname"
        Me.setname.Size = New System.Drawing.Size(52, 39)
        Me.setname.TabIndex = 27
        Me.setname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.setname.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Black
        Me.user.Location = New System.Drawing.Point(92, 76)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(36, 27)
        Me.user.TabIndex = 24
        Me.user.Text = "...."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 26)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Pristina", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(69, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 35)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "My Tasks!"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-8, 68)
        Me.ProgressBar1.MarqueeAnimationSpeed = 8
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(812, 5)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 22
        '
        'vif
        '
        Me.vif.AutoSize = True
        Me.vif.BackColor = System.Drawing.Color.Transparent
        Me.vif.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vif.Location = New System.Drawing.Point(70, 7)
        Me.vif.Name = "vif"
        Me.vif.Size = New System.Drawing.Size(87, 26)
        Me.vif.TabIndex = 20
        Me.vif.Text = "Vifarnet"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.task
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.Transparent
        Me.change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg
        Me.change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.change.Location = New System.Drawing.Point(760, 148)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(52, 39)
        Me.change.TabIndex = 32
        Me.change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.change.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Transparent
        Me.reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reset.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.refresh
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reset.Location = New System.Drawing.Point(760, 193)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(52, 39)
        Me.reset.TabIndex = 33
        Me.reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.reset.UseVisualStyleBackColor = False
        '
        'mt_abt
        '
        Me.mt_abt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_abt.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt_abt.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.infoy
        Me.mt_abt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mt_abt.Location = New System.Drawing.Point(750, 402)
        Me.mt_abt.Name = "mt_abt"
        Me.mt_abt.Size = New System.Drawing.Size(62, 47)
        Me.mt_abt.TabIndex = 34
        Me.mt_abt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mt_abt.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.AllowDrop = True
        Me.txt1.AutoSize = True
        Me.txt1.BackColor = System.Drawing.Color.Transparent
        Me.txt1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(3, 138)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(218, 22)
        Me.txt1.TabIndex = 35
        Me.txt1.Text = "Set the time for today's task" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dt
        '
        Me.dt.AllowDrop = True
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dt.Location = New System.Drawing.Point(15, 167)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(180, 20)
        Me.dt.TabIndex = 37
        '
        'book
        '
        Me.book.AllowDrop = True
        Me.book.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book.Location = New System.Drawing.Point(15, 399)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(113, 38)
        Me.book.TabIndex = 38
        Me.book.Text = "Book Reminder"
        Me.book.UseVisualStyleBackColor = True
        '
        'des
        '
        Me.des.AllowDrop = True
        Me.des.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des.Location = New System.Drawing.Point(15, 235)
        Me.des.Multiline = True
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(707, 158)
        Me.des.TabIndex = 39
        Me.des.Text = "Description"
        '
        'title
        '
        Me.title.AllowDrop = True
        Me.title.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(15, 198)
        Me.title.Multiline = True
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(707, 33)
        Me.title.TabIndex = 40
        Me.title.Text = "Title/Subject"
        '
        'm
        '
        Me.m.Interval = 1000
        '
        'nfi
        '
        Me.nfi.BalloonTipText = "Notification"
        Me.nfi.ContextMenuStrip = Me.TrayMenu
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "My Tasks"
        '
        'TrayMenu
        '
        Me.TrayMenu.BackColor = System.Drawing.Color.White
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showMTasks, Me.Xit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(166, 48)
        '
        'showMTasks
        '
        Me.showMTasks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMTasks.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.task
        Me.showMTasks.Name = "showMTasks"
        Me.showMTasks.Size = New System.Drawing.Size(165, 22)
        Me.showMTasks.Text = "Show 'My Tasks'"
        Me.showMTasks.ToolTipText = "Show My Tasks app window"
        '
        'Xit
        '
        Me.Xit.BackColor = System.Drawing.Color.White
        Me.Xit.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close1
        Me.Xit.Name = "Xit"
        Me.Xit.Size = New System.Drawing.Size(165, 22)
        Me.Xit.Text = "Exit My Tasks"
        Me.Xit.ToolTipText = "Exit My Tasks"
        '
        'booked
        '
        Me.booked.BackColor = System.Drawing.Color.Transparent
        Me.booked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.booked.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booked.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.taskx
        Me.booked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.booked.Location = New System.Drawing.Point(760, 257)
        Me.booked.Name = "booked"
        Me.booked.Size = New System.Drawing.Size(52, 39)
        Me.booked.TabIndex = 42
        Me.booked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.booked.UseVisualStyleBackColor = False
        '
        'min
        '
        Me.min.BackColor = System.Drawing.Color.Transparent
        Me.min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.min.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.min
        Me.min.Location = New System.Drawing.Point(747, 2)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(27, 26)
        Me.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.min.TabIndex = 49
        Me.min.TabStop = False
        '
        'xitmt
        '
        Me.xitmt.BackColor = System.Drawing.Color.Transparent
        Me.xitmt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xitmt.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close2
        Me.xitmt.Location = New System.Drawing.Point(774, 2)
        Me.xitmt.Name = "xitmt"
        Me.xitmt.Size = New System.Drawing.Size(27, 26)
        Me.xitmt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.xitmt.TabIndex = 48
        Me.xitmt.TabStop = False
        '
        'Vifmt
        '
        Me.AcceptButton = Me.book
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bar3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.xitmt)
        Me.Controls.Add(Me.booked)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.setname)
        Me.Controls.Add(Me.mt_abt)
        Me.Controls.Add(Me.book)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.vif)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.des)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vifmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet My Tasks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrayMenu.ResumeLayout(False)
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xitmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents setname As System.Windows.Forms.Button
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents vif As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents change As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents mt_abt As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents book As System.Windows.Forms.Button
    Friend WithEvents des As System.Windows.Forms.TextBox
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents m As System.Windows.Forms.Timer
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Xit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents showMTasks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents booked As System.Windows.Forms.Button
    Friend WithEvents min As System.Windows.Forms.PictureBox
    Friend WithEvents xitmt As System.Windows.Forms.PictureBox
End Class
