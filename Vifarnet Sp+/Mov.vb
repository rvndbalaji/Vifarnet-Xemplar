Public Class Mov
    Private Sub hlpsup_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseEnter
        hlpsup_img.BackColor = Color.AliceBlue
        hlpsup_text.Visible = True
        hlpsup_text.Location = New System.Drawing.Point(1195, 84)
    End Sub

    Private Sub hlpsup_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseLeave
        hlpsup_img.BackColor = Color.Transparent
        hlpsup_text.Visible = False
    End Sub

    Private Sub abt_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseEnter
        abt_img.BackColor = Color.AliceBlue
        abt_text.Visible = True
        abt_text.Location = New System.Drawing.Point(1217, 84)
    End Sub

    Private Sub abt_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseLeave
        abt_img.BackColor = Color.Transparent
        abt_text.Visible = False
    End Sub

    Private Sub Mov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Private Sub abt_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.Click
        Me.WindowState = FormWindowState.Minimized
        abt_mov.Show()
        abt_mov.Activate()
    End Sub

    Private Sub hlpsup_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.Click
        Dialog2.ShowDialog()
    End Sub
    Private Sub main_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_img.MouseEnter
        gotostrtpage_img.BackColor = Color.AliceBlue
        gotostrtpage_text.Visible = True
        gotostrtpage_text.Location = New System.Drawing.Point(1001, 84)

    End Sub

    Private Sub main_open1_Click(sender As System.Object, e As System.EventArgs) Handles gotostrtpage_img.MouseLeave
        gotostrtpage_img.BackColor = Color.Transparent
        gotostrtpage_text.Visible = False

    End Sub

    Private Sub gotostrtpage_img_Click(sender As System.Object, e As System.EventArgs) Handles gotostrtpage_img.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        VifFixIt.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles title_subseries_img1.Click
        ' Process.Start("D:\Movies\English\Twilight Saga\Twilight.mkv")
        Dialog2.ShowDialog()
    End Sub

    Private Sub title_subseries_img2_Click(sender As System.Object, e As System.EventArgs) Handles title_subseries_img2.Click
        ' Process.Start("D:\Movies\English\Twilight Saga\New Moon.mp4")
        Dialog2.ShowDialog()
    End Sub

    Private Sub title_subseries_img3_Click(sender As System.Object, e As System.EventArgs) Handles title_subseries_img3.Click
        ' Process.Start("D:\Movies\English\Twilight Saga\Eclipse.mp4")
        Dialog2.ShowDialog()
    End Sub

    Private Sub title_subseries_img4_Click(sender As System.Object, e As System.EventArgs) Handles title_subseries_img4.Click
        MessageBox.Show("Breaking Dawn is yet to be licensed under Vifarnet (Coming Soon)." & vbNewLine & "You'll be notified when its licensed.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        'Process.Start("D:\Movies\English\Mission Impossible\Mission Impossible 1 1996.mp4")
        Dialog2.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        ' Process.Start("D:\Movies\English\Mission Impossible\Mission Impossible 2 2000.mp4")
        Dialog2.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        'Process.Start("D:\Movies\English\Mission Impossible\Mission Impossible 3 2006.mp4")
        Dialog2.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Mission Impossible 4: Ghost Protocol is yet to be licensed under Vifarnet (Coming Soon)." & vbNewLine & "You'll be notified when its licensed.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
