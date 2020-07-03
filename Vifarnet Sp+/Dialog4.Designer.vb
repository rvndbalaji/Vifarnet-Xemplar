<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog4))
        Me.OK1 = New System.Windows.Forms.Button()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.msg1 = New System.Windows.Forms.Label()
        Me.title1 = New System.Windows.Forms.Label()
        Me.banner2 = New System.Windows.Forms.PictureBox()
        Me.banner1 = New System.Windows.Forms.PictureBox()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK1
        '
        Me.OK1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.OK1
        Me.OK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK1.Location = New System.Drawing.Point(244, 143)
        Me.OK1.Name = "OK1"
        Me.OK1.Size = New System.Drawing.Size(43, 36)
        Me.OK1.TabIndex = 19
        Me.OK1.UseVisualStyleBackColor = True
        '
        'icon1
        '
        Me.icon1.BackColor = System.Drawing.Color.White
        Me.icon1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg1
        Me.icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icon1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.Alert
        Me.icon1.Location = New System.Drawing.Point(0, 0)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(51, 43)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.icon1.TabIndex = 18
        Me.icon1.TabStop = False
        '
        'msg1
        '
        Me.msg1.AutoSize = True
        Me.msg1.BackColor = System.Drawing.Color.Transparent
        Me.msg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.msg1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg1.Location = New System.Drawing.Point(0, 43)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(533, 80)
        Me.msg1.TabIndex = 17
        Me.msg1.Text = resources.GetString("msg1.Text")
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.title1.Location = New System.Drawing.Point(55, 11)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(426, 27)
        Me.title1.TabIndex = 14
        Me.title1.Text = "Something's wrong!                       "
        '
        'banner2
        '
        Me.banner2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner2.Location = New System.Drawing.Point(-2, 143)
        Me.banner2.Name = "banner2"
        Me.banner2.Size = New System.Drawing.Size(535, 36)
        Me.banner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner2.TabIndex = 15
        Me.banner2.TabStop = False
        '
        'banner1
        '
        Me.banner1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner1.Location = New System.Drawing.Point(-2, 0)
        Me.banner1.Name = "banner1"
        Me.banner1.Size = New System.Drawing.Size(535, 56)
        Me.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner1.TabIndex = 16
        Me.banner1.TabStop = False
        '
        'Dialog4
        '
        Me.AcceptButton = Me.OK1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(533, 177)
        Me.Controls.Add(Me.OK1)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.title1)
        Me.Controls.Add(Me.banner2)
        Me.Controls.Add(Me.banner1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK1 As System.Windows.Forms.Button
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents title1 As System.Windows.Forms.Label
    Friend WithEvents banner2 As System.Windows.Forms.PictureBox
    Friend WithEvents banner1 As System.Windows.Forms.PictureBox
End Class
