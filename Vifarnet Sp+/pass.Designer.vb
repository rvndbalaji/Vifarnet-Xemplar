<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.info = New System.Windows.Forms.Label()
        Me.des3 = New System.Windows.Forms.ProgressBar()
        Me.usr_title = New System.Windows.Forms.Label()
        Me.pass_title = New System.Windows.Forms.Label()
        Me.an = New System.Windows.Forms.TextBox()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Location = New System.Drawing.Point(52, 9)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(379, 38)
        Me.info.TabIndex = 38
        Me.info.Text = "This App. has been protected due to security reasons." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You'll have to verify your" & _
    "self before you can access it."
        '
        'des3
        '
        Me.des3.Location = New System.Drawing.Point(0, 52)
        Me.des3.MarqueeAnimationSpeed = 8
        Me.des3.Name = "des3"
        Me.des3.Size = New System.Drawing.Size(439, 5)
        Me.des3.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des3.TabIndex = 45
        '
        'usr_title
        '
        Me.usr_title.AutoSize = True
        Me.usr_title.BackColor = System.Drawing.Color.Transparent
        Me.usr_title.Font = New System.Drawing.Font("Cambria", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_title.ForeColor = System.Drawing.Color.Black
        Me.usr_title.Location = New System.Drawing.Point(0, 88)
        Me.usr_title.Name = "usr_title"
        Me.usr_title.Size = New System.Drawing.Size(85, 20)
        Me.usr_title.TabIndex = 47
        Me.usr_title.Text = "App name:"
        '
        'pass_title
        '
        Me.pass_title.AutoSize = True
        Me.pass_title.BackColor = System.Drawing.Color.Transparent
        Me.pass_title.Font = New System.Drawing.Font("Cambria", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_title.ForeColor = System.Drawing.Color.Black
        Me.pass_title.Location = New System.Drawing.Point(0, 131)
        Me.pass_title.Name = "pass_title"
        Me.pass_title.Size = New System.Drawing.Size(83, 20)
        Me.pass_title.TabIndex = 48
        Me.pass_title.Text = "Password:"
        '
        'an
        '
        Me.an.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.an.ForeColor = System.Drawing.Color.Black
        Me.an.Location = New System.Drawing.Point(91, 87)
        Me.an.Name = "an"
        Me.an.Size = New System.Drawing.Size(331, 25)
        Me.an.TabIndex = 49
        '
        'pw
        '
        Me.pw.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.Location = New System.Drawing.Point(91, 131)
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw.Size = New System.Drawing.Size(331, 29)
        Me.pw.TabIndex = 50
        '
        'OK
        '
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.OK2
        Me.OK.Location = New System.Drawing.Point(147, 163)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(143, 45)
        Me.OK.TabIndex = 62
        Me.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 220)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.an)
        Me.Controls.Add(Me.pass_title)
        Me.Controls.Add(Me.usr_title)
        Me.Controls.Add(Me.des3)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pass"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents des3 As System.Windows.Forms.ProgressBar
    Friend WithEvents usr_title As System.Windows.Forms.Label
    Friend WithEvents pass_title As System.Windows.Forms.Label
    Friend WithEvents an As System.Windows.Forms.TextBox
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
End Class
