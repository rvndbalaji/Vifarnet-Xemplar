<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ud2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ud2))
        Me.welcome = New System.Windows.Forms.Label()
        Me.intro1 = New System.Windows.Forms.Label()
        Me.check = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ok = New System.Windows.Forms.PictureBox()
        Me.updates_img = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updates_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(106, 112)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(421, 38)
        Me.welcome.TabIndex = 147
        Me.welcome.Text = "Vifarnet is outdated. Please update Vifarnet regularly, to get" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "new features and " & _
            "facilities"
        '
        'intro1
        '
        Me.intro1.AutoSize = True
        Me.intro1.BackColor = System.Drawing.Color.Transparent
        Me.intro1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro1.ForeColor = System.Drawing.Color.Maroon
        Me.intro1.Location = New System.Drawing.Point(60, 5)
        Me.intro1.Name = "intro1"
        Me.intro1.Size = New System.Drawing.Size(277, 37)
        Me.intro1.TabIndex = 145
        Me.intro1.Text = "Vifarnet is outdated!"
        '
        'check
        '
        Me.check.BackColor = System.Drawing.Color.Transparent
        Me.check.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.refresh
        Me.check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.check.Location = New System.Drawing.Point(157, 193)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(234, 41)
        Me.check.TabIndex = 149
        Me.check.Text = "Check for and install updates...."
        Me.check.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.check.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(554, 10)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 150
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.DarkRed
        Me.ok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ok.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close2
        Me.ok.Location = New System.Drawing.Point(0, 0)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(56, 46)
        Me.ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ok.TabIndex = 144
        Me.ok.TabStop = False
        '
        'updates_img
        '
        Me.updates_img.BackColor = System.Drawing.Color.Transparent
        Me.updates_img.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.updates_img.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.refresh1
        Me.updates_img.Location = New System.Drawing.Point(0, 0)
        Me.updates_img.Name = "updates_img"
        Me.updates_img.Size = New System.Drawing.Size(100, 261)
        Me.updates_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updates_img.TabIndex = 143
        Me.updates_img.TabStop = False
        '
        'ud2
        '
        Me.AcceptButton = Me.check
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 261)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.intro1)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.updates_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ud2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Updates"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updates_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents check As System.Windows.Forms.Button
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents intro1 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.PictureBox
    Friend WithEvents updates_img As System.Windows.Forms.PictureBox
End Class
