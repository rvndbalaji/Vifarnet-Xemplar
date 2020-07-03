<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog3))
        Me.msg1 = New System.Windows.Forms.Label()
        Me.p_msg = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.title1 = New System.Windows.Forms.Label()
        Me.banner2 = New System.Windows.Forms.PictureBox()
        Me.banner1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK3 = New System.Windows.Forms.Button()
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
        Me.msg1.Location = New System.Drawing.Point(0, 59)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(504, 120)
        Me.msg1.TabIndex = 16
        Me.msg1.Text = resources.GetString("msg1.Text")
        '
        'p_msg
        '
        Me.p_msg.AutoSize = True
        Me.p_msg.BackColor = System.Drawing.Color.Transparent
        Me.p_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.p_msg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.p_msg.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_msg.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.p_msg.Location = New System.Drawing.Point(382, 34)
        Me.p_msg.Name = "p_msg"
        Me.p_msg.Size = New System.Drawing.Size(122, 22)
        Me.p_msg.TabIndex = 19
        Me.p_msg.Text = "To Err is Human"
        '
        'icon1
        '
        Me.icon1.BackColor = System.Drawing.Color.White
        Me.icon1.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg1
        Me.icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icon1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources._error
        Me.icon1.Location = New System.Drawing.Point(0, 0)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(65, 56)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.icon1.TabIndex = 17
        Me.icon1.TabStop = False
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.title1.Location = New System.Drawing.Point(71, 18)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(391, 27)
        Me.title1.TabIndex = 13
        Me.title1.Text = "Update Failed!                          "
        '
        'banner2
        '
        Me.banner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.banner2.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner2.Location = New System.Drawing.Point(1, 243)
        Me.banner2.Name = "banner2"
        Me.banner2.Size = New System.Drawing.Size(504, 45)
        Me.banner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner2.TabIndex = 14
        Me.banner2.TabStop = False
        '
        'banner1
        '
        Me.banner1.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.bg6
        Me.banner1.Location = New System.Drawing.Point(-2, 0)
        Me.banner1.Name = "banner1"
        Me.banner1.Size = New System.Drawing.Size(546, 56)
        Me.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.banner1.TabIndex = 15
        Me.banner1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(505, 286)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -6
        Me.LineShape1.X2 = 527
        Me.LineShape1.Y1 = 179
        Me.LineShape1.Y2 = 179
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 40)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "You can try installing the update manually, by starting 'setup.exe'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will be" & _
            " taken to the update folder after this dialog box is closed"
        '
        'OK3
        '
        Me.OK3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OK3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK3.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.OK2
        Me.OK3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK3.Location = New System.Drawing.Point(160, 243)
        Me.OK3.Name = "OK3"
        Me.OK3.Size = New System.Drawing.Size(188, 43)
        Me.OK3.TabIndex = 18
        Me.OK3.Text = "Take me to the folder"
        Me.OK3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK3.UseVisualStyleBackColor = True
        '
        'Dialog3
        '
        Me.AcceptButton = Me.OK3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 286)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.p_msg)
        Me.Controls.Add(Me.OK3)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.msg1)
        Me.Controls.Add(Me.title1)
        Me.Controls.Add(Me.banner2)
        Me.Controls.Add(Me.banner1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents p_msg As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents title1 As System.Windows.Forms.Label
    Friend WithEvents banner2 As System.Windows.Forms.PictureBox
    Friend WithEvents banner1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OK3 As System.Windows.Forms.Button
End Class
