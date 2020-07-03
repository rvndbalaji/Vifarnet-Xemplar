<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ud1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ud1))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.intro1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ok = New System.Windows.Forms.PictureBox()
        Me.updates_img = New System.Windows.Forms.PictureBox()
        Me.welcome = New System.Windows.Forms.Label()
        Me.version = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updates_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(555, 261)
        Me.ShapeContainer1.TabIndex = 42
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 99
        Me.LineShape1.X2 = 558
        Me.LineShape1.Y1 = 45
        Me.LineShape1.Y2 = 45
        '
        'intro1
        '
        Me.intro1.AutoSize = True
        Me.intro1.BackColor = System.Drawing.Color.Transparent
        Me.intro1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intro1.ForeColor = System.Drawing.Color.DarkGreen
        Me.intro1.Location = New System.Drawing.Point(60, 5)
        Me.intro1.Name = "intro1"
        Me.intro1.Size = New System.Drawing.Size(302, 37)
        Me.intro1.TabIndex = 135
        Me.intro1.Text = "Vifarnet is up-to-date! "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bar
        Me.PictureBox1.Location = New System.Drawing.Point(0, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.LimeGreen
        Me.ok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ok.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.OK1
        Me.ok.Location = New System.Drawing.Point(0, 0)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(56, 46)
        Me.ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ok.TabIndex = 43
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
        Me.updates_img.TabIndex = 40
        Me.updates_img.TabStop = False
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(160, 97)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(296, 38)
        Me.welcome.TabIndex = 139
        Me.welcome.Text = "There are currently, no updates available." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vifarnet is Up-to-date."
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.BackColor = System.Drawing.Color.Transparent
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.ForeColor = System.Drawing.Color.Black
        Me.version.Location = New System.Drawing.Point(219, 154)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(124, 20)
        Me.version.TabIndex = 140
        Me.version.Text = "Version 2.53.4.6"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bar
        Me.PictureBox2.Location = New System.Drawing.Point(0, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(554, 10)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 142
        Me.PictureBox2.TabStop = False
        '
        'ud1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 261)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.intro1)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.updates_img)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ud1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Updates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updates_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updates_img As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ok As System.Windows.Forms.PictureBox
    Friend WithEvents intro1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
