<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class math
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(math))
        Me.vifarnet = New System.Windows.Forms.Label()
        Me.mov_name = New System.Windows.Forms.Label()
        Me.des3 = New System.Windows.Forms.ProgressBar()
        Me.tools = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cacl = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DipTheory = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cacl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vifarnet
        '
        Me.vifarnet.AutoSize = True
        Me.vifarnet.BackColor = System.Drawing.Color.Transparent
        Me.vifarnet.Font = New System.Drawing.Font("Baskerville Old Face", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vifarnet.Location = New System.Drawing.Point(72, 9)
        Me.vifarnet.Name = "vifarnet"
        Me.vifarnet.Size = New System.Drawing.Size(122, 38)
        Me.vifarnet.TabIndex = 93
        Me.vifarnet.Text = "Vifarnet"
        '
        'mov_name
        '
        Me.mov_name.AutoSize = True
        Me.mov_name.BackColor = System.Drawing.Color.Transparent
        Me.mov_name.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mov_name.ForeColor = System.Drawing.Color.IndianRed
        Me.mov_name.Location = New System.Drawing.Point(184, -2)
        Me.mov_name.Name = "mov_name"
        Me.mov_name.Size = New System.Drawing.Size(231, 56)
        Me.mov_name.TabIndex = 94
        Me.mov_name.Text = "Mathematics"
        '
        'des3
        '
        Me.des3.Location = New System.Drawing.Point(0, 57)
        Me.des3.MarqueeAnimationSpeed = 8
        Me.des3.Name = "des3"
        Me.des3.Size = New System.Drawing.Size(836, 5)
        Me.des3.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.des3.TabIndex = 95
        '
        'tools
        '
        Me.tools.AutoSize = True
        Me.tools.BackColor = System.Drawing.Color.Transparent
        Me.tools.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tools.ForeColor = System.Drawing.Color.IndianRed
        Me.tools.Location = New System.Drawing.Point(710, 62)
        Me.tools.Name = "tools"
        Me.tools.Size = New System.Drawing.Size(57, 24)
        Me.tools.TabIndex = 98
        Me.tools.Text = "Tools"
        '
        'tip
        '
        Me.tip.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip.ToolTipTitle = "Component:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.math5
        Me.PictureBox1.Location = New System.Drawing.Point(650, 241)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        Me.tip.SetToolTip(Me.PictureBox1, "Math Input Panel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Windows 7)")
        '
        'Cacl
        '
        Me.Cacl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cacl.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.calc1
        Me.Cacl.Location = New System.Drawing.Point(705, 98)
        Me.Cacl.Name = "Cacl"
        Me.Cacl.Size = New System.Drawing.Size(89, 127)
        Me.Cacl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cacl.TabIndex = 97
        Me.Cacl.TabStop = False
        Me.tip.SetToolTip(Me.Cacl, "Caculator (Windows)")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.math1
        Me.PictureBox2.Location = New System.Drawing.Point(43, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(562, 241)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'DipTheory
        '
        Me.DipTheory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DipTheory.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DipTheory.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.math4
        Me.DipTheory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DipTheory.Location = New System.Drawing.Point(674, 445)
        Me.DipTheory.Name = "DipTheory"
        Me.DipTheory.Size = New System.Drawing.Size(141, 50)
        Me.DipTheory.TabIndex = 96
        Me.DipTheory.Text = "Dip Theory"
        Me.DipTheory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DipTheory.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.math3
        Me.logo.Location = New System.Drawing.Point(1, 2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(71, 54)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 91
        Me.logo.TabStop = False
        '
        'math
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(837, 498)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tools)
        Me.Controls.Add(Me.Cacl)
        Me.Controls.Add(Me.DipTheory)
        Me.Controls.Add(Me.des3)
        Me.Controls.Add(Me.vifarnet)
        Me.Controls.Add(Me.mov_name)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "math"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Mathematics"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cacl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vifarnet As System.Windows.Forms.Label
    Friend WithEvents mov_name As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents des3 As System.Windows.Forms.ProgressBar
    Friend WithEvents DipTheory As System.Windows.Forms.Button
    Friend WithEvents Cacl As System.Windows.Forms.PictureBox
    Friend WithEvents tools As System.Windows.Forms.Label
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
