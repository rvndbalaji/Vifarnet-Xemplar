Public Class music

    Private Sub akon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles akon.MouseEnter
        dis0.Visible = True
        dis0.Text = "Akon Thiam"
    End Sub

    Private Sub akon_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles akon.MouseLeave

        dis0.Visible = False
    End Sub

    Private Sub bb_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb.MouseEnter

        dis0.Text = "Backstreet Boys"
        dis0.Visible = True
    End Sub

    Private Sub bb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb.MouseLeave

        dis0.Visible = False
    End Sub

    Private Sub bm_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bm.MouseEnter
        dis0.Text = "Bruno Mars"
        dis0.Visible = True
    End Sub

    Private Sub bm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bm.MouseLeave

        dis0.Visible = False
    End Sub
    Private Sub em_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles em.MouseEnter
        dis0.Text = "Eminem (Shady)"
        dis0.Visible = True
    End Sub

    Private Sub em_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles em.MouseLeave

        dis0.Visible = False
    End Sub
    Private Sub enig_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enig.MouseEnter

        dis0.Text = "Enrique Iglesias"
        dis0.Visible = True
    End Sub

    Private Sub enig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enig.MouseLeave

        dis0.Visible = False
    End Sub
    Private Sub gd_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gd.MouseEnter
        dis0.Text = "Green Day"
        dis0.Visible = True
    End Sub

    Private Sub gd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gd.MouseLeave

        dis0.Visible = False
    End Sub

    Private Sub m_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_name.Click
        If m_abt.Visible = True And
           m_arr.Visible = True And
           m_hlpsupp.Visible = True And
           m_gotostrtpage.Visible = True And
           m_rfsh.Visible = True Then


            m_abt.Visible = False
            m_arr.Visible = False
            m_hlpsupp.Visible = False
            m_gotostrtpage.Visible = False
            m_rfsh.Visible = False


        Else
            m_abt.Visible = True
            m_arr.Visible = True
            m_hlpsupp.Visible = True
            m_gotostrtpage.Visible = True
            m_rfsh.Visible = True


        End If
    End Sub

    Private Sub RefreshWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_rfsh.Click
        Me.Refresh()
    End Sub

    Private Sub m_hlpsupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_hlpsupp.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub m_abt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_abt.Click
        Me.WindowState = FormWindowState.Minimized
        abt_music.Show()
        abt_music.Activate()
    End Sub

    Private Sub VifarnetMainPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_txt.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        Mov.WindowState = FormWindowState.Minimized
        VifFixIt.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitVifarnetFixItToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        StrtScrn.block.Dock = DockStyle.Fill
        StrtScrn.block.Visible = True
        quit.ShowDialog()
    End Sub

    Private Sub abt_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.Click
        Me.WindowState = FormWindowState.Minimized
        abt_music.Show()
        abt_music.Activate()
    End Sub

    Private Sub hlpsup_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub main_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_img.MouseEnter
        gotostrtpage_img.BackColor = Color.White
        gotostrtpage_text.Visible = True
        gotostrtpage_text.Location = New System.Drawing.Point(995, 102)

    End Sub
    Private Sub main_open1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_img.MouseLeave
        gotostrtpage_img.BackColor = Color.Transparent
        gotostrtpage_text.Visible = False

    End Sub

    Private Sub gotostrtpage_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_img.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        Mov.WindowState = FormWindowState.Minimized
        VifFixIt.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub abt_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseEnter
        abt_img.BackColor = Color.White
        abt_text.Visible = True
        abt_text.Location = New System.Drawing.Point(1200, 105)
    End Sub

    Private Sub abt_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseLeave
        abt_img.BackColor = Color.Transparent
        abt_text.Visible = False
    End Sub
    Private Sub hlpsup_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseEnter
        hlpsup_img.BackColor = Color.White
        hlpsup_text.Visible = True
        hlpsup_text.Location = New System.Drawing.Point(1190, 102)

    End Sub

    Private Sub hlpsup_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseLeave
        hlpsup_img.BackColor = Color.Transparent
        hlpsup_text.Visible = False
       
    End Sub

    Private Sub music_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Private Sub akon_Click_1(sender As System.Object, e As System.EventArgs) Handles akon.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub bb_Click_1(sender As System.Object, e As System.EventArgs) Handles bb.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub bm_Click_1(sender As System.Object, e As System.EventArgs) Handles bm.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub em_Click_1(sender As System.Object, e As System.EventArgs) Handles em.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub enig_Click_1(sender As System.Object, e As System.EventArgs) Handles enig.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub gd_Click_1(sender As System.Object, e As System.EventArgs) Handles gd.Click
        Dialog2.ShowDialog()
    End Sub

End Class