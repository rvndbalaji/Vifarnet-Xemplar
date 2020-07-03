<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abt_fixit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abt_fixit))
        Me.vifarnet = New System.Windows.Forms.Label()
        Me.VifCorp = New System.Windows.Forms.Label()
        Me.rtsresrv = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        Me.fixit_name = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vifarnet
        '
        Me.vifarnet.AutoSize = True
        Me.vifarnet.BackColor = System.Drawing.Color.Transparent
        Me.vifarnet.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vifarnet.Location = New System.Drawing.Point(185, 32)
        Me.vifarnet.Name = "vifarnet"
        Me.vifarnet.Size = New System.Drawing.Size(88, 27)
        Me.vifarnet.TabIndex = 76
        Me.vifarnet.Text = "Vifarnet"
        '
        'VifCorp
        '
        Me.VifCorp.AutoSize = True
        Me.VifCorp.BackColor = System.Drawing.Color.Transparent
        Me.VifCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VifCorp.Location = New System.Drawing.Point(176, 293)
        Me.VifCorp.Name = "VifCorp"
        Me.VifCorp.Size = New System.Drawing.Size(211, 20)
        Me.VifCorp.TabIndex = 81
        Me.VifCorp.Text = "© 2012 Vifarnet Corporation "
        '
        'rtsresrv
        '
        Me.rtsresrv.AutoSize = True
        Me.rtsresrv.BackColor = System.Drawing.Color.Transparent
        Me.rtsresrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtsresrv.Location = New System.Drawing.Point(203, 313)
        Me.rtsresrv.Name = "rtsresrv"
        Me.rtsresrv.Size = New System.Drawing.Size(152, 20)
        Me.rtsresrv.TabIndex = 82
        Me.rtsresrv.Text = "All Rights Reserved."
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Transparent
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.Xemplar
        Me.pic.Location = New System.Drawing.Point(502, 293)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(70, 70)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 94
        Me.pic.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Transparent
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.fixit
        Me.logo2.Location = New System.Drawing.Point(180, 71)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(199, 187)
        Me.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo2.TabIndex = 75
        Me.logo2.TabStop = False
        '
        'fixit_name
        '
        Me.fixit_name.AutoSize = True
        Me.fixit_name.BackColor = System.Drawing.Color.Transparent
        Me.fixit_name.Font = New System.Drawing.Font("Curlz MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fixit_name.ForeColor = System.Drawing.Color.SlateBlue
        Me.fixit_name.Location = New System.Drawing.Point(279, 20)
        Me.fixit_name.Name = "fixit_name"
        Me.fixit_name.Size = New System.Drawing.Size(90, 43)
        Me.fixit_name.TabIndex = 96
        Me.fixit_name.Text = "Fix It"
        '
        'abt_fixit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 360)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.vifarnet)
        Me.Controls.Add(Me.VifCorp)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.rtsresrv)
        Me.Controls.Add(Me.fixit_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "abt_fixit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Vifarnet Fix it"
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
    Friend WithEvents fixit_name As System.Windows.Forms.Label
End Class
