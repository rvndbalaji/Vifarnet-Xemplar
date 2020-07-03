<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abt_music
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abt_music))
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.vifarnet = New System.Windows.Forms.Label()
        Me.VifCorp = New System.Windows.Forms.Label()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        Me.rtsresrv = New System.Windows.Forms.Label()
        Me.mov_name = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Transparent
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.Xemplar
        Me.pic.Location = New System.Drawing.Point(501, 293)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(70, 70)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 109
        Me.pic.TabStop = False
        '
        'vifarnet
        '
        Me.vifarnet.AutoSize = True
        Me.vifarnet.BackColor = System.Drawing.Color.Transparent
        Me.vifarnet.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vifarnet.Location = New System.Drawing.Point(180, 41)
        Me.vifarnet.Name = "vifarnet"
        Me.vifarnet.Size = New System.Drawing.Size(88, 27)
        Me.vifarnet.TabIndex = 99
        Me.vifarnet.Text = "Vifarnet"
        '
        'VifCorp
        '
        Me.VifCorp.AutoSize = True
        Me.VifCorp.BackColor = System.Drawing.Color.Transparent
        Me.VifCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VifCorp.Location = New System.Drawing.Point(170, 293)
        Me.VifCorp.Name = "VifCorp"
        Me.VifCorp.Size = New System.Drawing.Size(211, 20)
        Me.VifCorp.TabIndex = 101
        Me.VifCorp.Text = "© 2012 Vifarnet Corporation "
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Transparent
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.dj
        Me.logo2.Location = New System.Drawing.Point(174, 83)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(199, 187)
        Me.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo2.TabIndex = 98
        Me.logo2.TabStop = False
        '
        'rtsresrv
        '
        Me.rtsresrv.AutoSize = True
        Me.rtsresrv.BackColor = System.Drawing.Color.Transparent
        Me.rtsresrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtsresrv.Location = New System.Drawing.Point(197, 313)
        Me.rtsresrv.Name = "rtsresrv"
        Me.rtsresrv.Size = New System.Drawing.Size(152, 20)
        Me.rtsresrv.TabIndex = 102
        Me.rtsresrv.Text = "All Rights Reserved."
        '
        'mov_name
        '
        Me.mov_name.AutoSize = True
        Me.mov_name.BackColor = System.Drawing.Color.Transparent
        Me.mov_name.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mov_name.ForeColor = System.Drawing.Color.Tomato
        Me.mov_name.Location = New System.Drawing.Point(263, 32)
        Me.mov_name.Name = "mov_name"
        Me.mov_name.Size = New System.Drawing.Size(85, 42)
        Me.mov_name.TabIndex = 112
        Me.mov_name.Text = "Music"
        '
        'abt_music
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 360)
        Me.Controls.Add(Me.vifarnet)
        Me.Controls.Add(Me.mov_name)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.VifCorp)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.rtsresrv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "abt_music"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Music"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents vifarnet As System.Windows.Forms.Label
    Friend WithEvents VifCorp As System.Windows.Forms.Label
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents rtsresrv As System.Windows.Forms.Label
    Friend WithEvents mov_name As System.Windows.Forms.Label
End Class
