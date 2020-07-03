<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quit))
        Me.VifCorp = New System.Windows.Forms.Label()
        Me.a_txt = New System.Windows.Forms.Label()
        Me.b_txt = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Button()
        Me.b = New System.Windows.Forms.Button()
        Me.Xit = New System.Windows.Forms.PictureBox()
        CType(Me.Xit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VifCorp
        '
        Me.VifCorp.AutoSize = True
        Me.VifCorp.BackColor = System.Drawing.Color.Transparent
        Me.VifCorp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.VifCorp.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VifCorp.ForeColor = System.Drawing.Color.White
        Me.VifCorp.Location = New System.Drawing.Point(176, 9)
        Me.VifCorp.Name = "VifCorp"
        Me.VifCorp.Size = New System.Drawing.Size(260, 37)
        Me.VifCorp.TabIndex = 75
        Me.VifCorp.Text = "Choose the way to quit"
        '
        'a_txt
        '
        Me.a_txt.AutoSize = True
        Me.a_txt.BackColor = System.Drawing.Color.Transparent
        Me.a_txt.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.a_txt.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_txt.ForeColor = System.Drawing.Color.Black
        Me.a_txt.Location = New System.Drawing.Point(12, 110)
        Me.a_txt.Name = "a_txt"
        Me.a_txt.Size = New System.Drawing.Size(245, 22)
        Me.a_txt.TabIndex = 79
        Me.a_txt.Text = "Whole program will be closed"
        '
        'b_txt
        '
        Me.b_txt.AutoSize = True
        Me.b_txt.BackColor = System.Drawing.Color.Transparent
        Me.b_txt.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.b_txt.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_txt.ForeColor = System.Drawing.Color.Black
        Me.b_txt.Location = New System.Drawing.Point(326, 110)
        Me.b_txt.Name = "b_txt"
        Me.b_txt.Size = New System.Drawing.Size(291, 44)
        Me.b_txt.TabIndex = 81
        Me.b_txt.Text = "Only the Start Screen will be closed," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "leaving other apps (if opened)"
        Me.b_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.Transparent
        Me.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.a.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.a.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.a.Location = New System.Drawing.Point(16, 62)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(226, 45)
        Me.a.TabIndex = 83
        Me.a.Text = "Vifarnet X-emplar"
        Me.a.UseVisualStyleBackColor = False
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.Transparent
        Me.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.Color.White
        Me.b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b.Location = New System.Drawing.Point(347, 62)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(226, 45)
        Me.b.TabIndex = 82
        Me.b.Text = "Start Screen"
        Me.b.UseVisualStyleBackColor = False
        '
        'Xit
        '
        Me.Xit.BackColor = System.Drawing.Color.Transparent
        Me.Xit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Xit.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close2
        Me.Xit.Location = New System.Drawing.Point(626, 0)
        Me.Xit.Name = "Xit"
        Me.Xit.Size = New System.Drawing.Size(27, 26)
        Me.Xit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Xit.TabIndex = 84
        Me.Xit.TabStop = False
        '
        'quit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg13
        Me.ClientSize = New System.Drawing.Size(651, 182)
        Me.Controls.Add(Me.Xit)
        Me.Controls.Add(Me.b_txt)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.a_txt)
        Me.Controls.Add(Me.VifCorp)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "quit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Xit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VifCorp As System.Windows.Forms.Label
    Friend WithEvents a_txt As System.Windows.Forms.Label
    Friend WithEvents b_txt As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.Button
    Friend WithEvents b As System.Windows.Forms.Button
    Friend WithEvents Xit As System.Windows.Forms.PictureBox
End Class
