<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xp))
        Me.title = New System.Windows.Forms.Button()
        Me.t = New System.Windows.Forms.Timer(Me.components)
        Me.cnt1 = New System.Windows.Forms.Label()
        Me.res = New System.Windows.Forms.ListBox()
        Me.srch = New System.Windows.Forms.Button()
        Me.srchbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.title.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xp
        Me.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.title.Location = New System.Drawing.Point(-5, -1)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(1376, 65)
        Me.title.TabIndex = 0
        Me.title.Text = "Xperiment"
        Me.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.title.UseVisualStyleBackColor = False
        '
        't
        '
        Me.t.Interval = 50
        '
        'cnt1
        '
        Me.cnt1.AutoSize = True
        Me.cnt1.BackColor = System.Drawing.Color.Transparent
        Me.cnt1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnt1.ForeColor = System.Drawing.Color.White
        Me.cnt1.Location = New System.Drawing.Point(267, 225)
        Me.cnt1.Name = "cnt1"
        Me.cnt1.Size = New System.Drawing.Size(153, 26)
        Me.cnt1.TabIndex = 152
        Me.cnt1.Text = "Ready to search"
        '
        'res
        '
        Me.res.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.res.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res.FormattingEnabled = True
        Me.res.ItemHeight = 22
        Me.res.Location = New System.Drawing.Point(22, 207)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(1316, 510)
        Me.res.TabIndex = 151
        '
        'srch
        '
        Me.srch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.srch.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.xplore
        Me.srch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.srch.Location = New System.Drawing.Point(566, 126)
        Me.srch.Name = "srch"
        Me.srch.Size = New System.Drawing.Size(201, 65)
        Me.srch.TabIndex = 150
        Me.srch.Text = "Begin the search!"
        Me.srch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.srch.UseVisualStyleBackColor = True
        '
        'srchbox
        '
        Me.srchbox.AcceptsReturn = True
        Me.srchbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.srchbox.BackColor = System.Drawing.Color.White
        Me.srchbox.Font = New System.Drawing.Font("Palatino Linotype", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchbox.Location = New System.Drawing.Point(254, 81)
        Me.srchbox.Name = "srchbox"
        Me.srchbox.Size = New System.Drawing.Size(812, 39)
        Me.srchbox.TabIndex = 149
        '
        'xp
        '
        Me.AcceptButton = Me.title
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.cnt1)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.srch)
        Me.Controls.Add(Me.srchbox)
        Me.Controls.Add(Me.title)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "xp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vifarnet Xperiment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Button
    Friend WithEvents t As System.Windows.Forms.Timer
    Friend WithEvents cnt1 As System.Windows.Forms.Label
    Friend WithEvents res As System.Windows.Forms.ListBox
    Friend WithEvents srch As System.Windows.Forms.Button
    Friend WithEvents srchbox As System.Windows.Forms.TextBox
End Class
