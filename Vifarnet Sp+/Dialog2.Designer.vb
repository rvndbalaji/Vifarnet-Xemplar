<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog2))
        Me.msg1 = New System.Windows.Forms.Label()
        Me.OK2 = New System.Windows.Forms.Button()
        Me.p_msg = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.title1 = New System.Windows.Forms.Label()
        Me.banner2 = New System.Windows.Forms.PictureBox()
        Me.banner1 = New System.Windows.Forms.PictureBox()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msg1
        '
        Me.msg1.AutoSize = True
        Me.msg1.BackColor = System.Drawing.Color.Transparent
        Me.msg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.msg1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg1.Location = New System.Drawing.Point(0, 43)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(543, 100)
        Me.msg1.TabIndex = 9
        Me.msg1.Text = resources.GetString("msg1.Text")
        '
        'OK2
        '
        Me.OK2.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.OK1
        Me.OK2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OK2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK2.Location = New System.Drawing.Point(251, 162)
        Me.OK2.Name = "OK2"
        Me.OK2.Size = New System.Drawing.Size(43, 38)
        Me.OK2.TabIndex = 11
        Me.OK2.UseVisualStyleBackColor = True
        '
        'p_msg
        '
        Me.p_msg.AutoSize = True
        Me.p_msg.BackColor = System.Drawing.Color.Transparent
        Me.p_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.p_msg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.p_msg.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_msg.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.p_msg.Location = New System.Drawing.Point(317, 23)
        Me.p_msg.Name = "p_msg"
        Me.p_msg.Size = New System.Drawing.Size(227, 20)
        Me.p_msg.TabIndex = 12
        Me.p_msg.Text = "We're sorry for the inconvenience. :\"
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
        Me.icon1.TabIndex = 10
        Me.icon1.TabStop = False
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.title1.Location = New System.Drawing.Point(58, 11)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(430, 27)
        Me.title1.TabIndex = 6
        Me.title1.Text = "Unavailable                                   "
        '
        'banner2
        '
        Me.banner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.banner2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner2.Location = New System.Drawing.Point(0, 162)
        Me.banner2.Name = "banner2"
        Me.banner2.Size = New System.Drawing.Size(542, 38)
        Me.banner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner2.TabIndex = 7
        Me.banner2.TabStop = False
        '
        'banner1
        '
        Me.banner1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner1.Location = New System.Drawing.Point(-2, 0)
        Me.banner1.Name = "banner1"
        Me.banner1.Size = New System.Drawing.Size(546, 56)
        Me.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner1.TabIndex = 8
        Me.banner1.TabStop = False
        '
        'Dialog2
        '
        Me.AcceptButton = Me.OK2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 199)
        Me.Controls.Add(Me.p_msg)
        Me.Controls.Add(Me.OK2)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.title1)
        Me.Controls.Add(Me.banner2)
        Me.Controls.Add(Me.banner1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents title1 As System.Windows.Forms.Label
    Friend WithEvents banner2 As System.Windows.Forms.PictureBox
    Friend WithEvents banner1 As System.Windows.Forms.PictureBox
    Friend WithEvents OK2 As System.Windows.Forms.Button
    Friend WithEvents p_msg As System.Windows.Forms.Label
End Class
