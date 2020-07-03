<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BG
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
        Me.cancel = New System.Windows.Forms.Button()
        Me.apply = New System.Windows.Forms.Button()
        Me.go1 = New System.Windows.Forms.Button()
        Me.bg1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.bg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.Transparent
        Me.cancel.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.close1
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.Location = New System.Drawing.Point(960, 407)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(271, 38)
        Me.cancel.TabIndex = 11
        Me.cancel.Text = "Cancel && Keep the same image"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.UseVisualStyleBackColor = False
        '
        'apply
        '
        Me.apply.BackColor = System.Drawing.Color.Transparent
        Me.apply.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apply.Image = Global.Vifarnet_Xplr_.My.Resources.Resources.OK2
        Me.apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.apply.Location = New System.Drawing.Point(960, 352)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(271, 38)
        Me.apply.TabIndex = 10
        Me.apply.Text = "Apply background Image"
        Me.apply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.apply.UseVisualStyleBackColor = False
        '
        'go1
        '
        Me.go1.BackColor = System.Drawing.Color.Transparent
        Me.go1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go1.Location = New System.Drawing.Point(3, 117)
        Me.go1.Name = "go1"
        Me.go1.Size = New System.Drawing.Size(53, 30)
        Me.go1.TabIndex = 9
        Me.go1.Text = "GO!"
        Me.go1.UseVisualStyleBackColor = False
        '
        'bg1
        '
        Me.bg1.BackColor = System.Drawing.Color.Transparent
        Me.bg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bg1.ErrorImage = Nothing
        Me.bg1.ImageLocation = "My.Resources.bar3"
        Me.bg1.Location = New System.Drawing.Point(18, 170)
        Me.bg1.Name = "bg1"
        Me.bg1.Size = New System.Drawing.Size(808, 478)
        Me.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bg1.TabIndex = 8
        Me.bg1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Specify the path of the image file which is to be set as the app background:"
        '
        'b1
        '
        Me.b1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(62, 119)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(775, 28)
        Me.b1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(499, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(396, 47)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customize App Background"
        '
        'BG
        '
        Me.AcceptButton = Me.go1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Vifarnet_Xplr_.My.Resources.Resources.bg14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1340, 703)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.apply)
        Me.Controls.Add(Me.go1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.bg1)
        Me.MinimumSize = New System.Drawing.Size(1356, 720)
        Me.Name = "BG"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change App Background"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents apply As System.Windows.Forms.Button
    Friend WithEvents go1 As System.Windows.Forms.Button
    Friend WithEvents bg1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
