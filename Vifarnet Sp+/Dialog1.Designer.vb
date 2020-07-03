<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog1))
        Me.title1 = New System.Windows.Forms.Label()
        Me.banner1 = New System.Windows.Forms.PictureBox()
        Me.msg1 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.banner2 = New System.Windows.Forms.PictureBox()
        Me.OK1 = New System.Windows.Forms.Button()
        Me.p_msg = New System.Windows.Forms.Label()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.title1.Location = New System.Drawing.Point(55, 9)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(318, 27)
        Me.title1.TabIndex = 0
        Me.title1.Text = "No results found!             "
        '
        'banner1
        '
        Me.banner1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner1.Location = New System.Drawing.Point(-2, 0)
        Me.banner1.Name = "banner1"
        Me.banner1.Size = New System.Drawing.Size(423, 56)
        Me.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner1.TabIndex = 2
        Me.banner1.TabStop = False
        '
        'msg1
        '
        Me.msg1.AutoSize = True
        Me.msg1.BackColor = System.Drawing.Color.Transparent
        Me.msg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.msg1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg1.Location = New System.Drawing.Point(0, 43)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(421, 80)
        Me.msg1.TabIndex = 3
        Me.msg1.Text = "Make sure to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Check for grammatical/spelling errors;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. See if the first let" & _
            "ter is Capitalized in the search string;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. See if the field (search box) has n" & _
            "ot been left BLANK.           "
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
        Me.icon1.TabIndex = 4
        Me.icon1.TabStop = False
        '
        'banner2
        '
        Me.banner2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner2.Location = New System.Drawing.Point(-2, 143)
        Me.banner2.Name = "banner2"
        Me.banner2.Size = New System.Drawing.Size(423, 36)
        Me.banner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner2.TabIndex = 1
        Me.banner2.TabStop = False
        '
        'OK1
        '
        Me.OK1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.OK1
        Me.OK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK1.Location = New System.Drawing.Point(189, 143)
        Me.OK1.Name = "OK1"
        Me.OK1.Size = New System.Drawing.Size(43, 36)
        Me.OK1.TabIndex = 6
        Me.OK1.UseVisualStyleBackColor = True
        '
        'p_msg
        '
        Me.p_msg.AutoSize = True
        Me.p_msg.BackColor = System.Drawing.Color.Transparent
        Me.p_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.p_msg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.p_msg.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_msg.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.p_msg.Location = New System.Drawing.Point(295, 23)
        Me.p_msg.Name = "p_msg"
        Me.p_msg.Size = New System.Drawing.Size(126, 20)
        Me.p_msg.TabIndex = 13
        Me.p_msg.Text = "Give it another try!"
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(421, 177)
        Me.Controls.Add(Me.p_msg)
        Me.Controls.Add(Me.OK1)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.title1)
        Me.Controls.Add(Me.banner2)
        Me.Controls.Add(Me.banner1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title1 As System.Windows.Forms.Label
    Friend WithEvents banner1 As System.Windows.Forms.PictureBox
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents banner2 As System.Windows.Forms.PictureBox
    Friend WithEvents OK1 As System.Windows.Forms.Button
    Friend WithEvents p_msg As System.Windows.Forms.Label
End Class
