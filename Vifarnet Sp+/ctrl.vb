Public Class ctrl

    Private Sub ctrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
        My.Settings.Save()
    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click



        'Apps
        If opt_music.Checked = True Then
            StrtScrn.m_img.Enabled = True
            StrtScrn.m_img.Image = My.Resources.dj


        Else : StrtScrn.m_img.Enabled = False
            StrtScrn.m_img.Image = My.Resources.dj_dis
        End If



        If opt_fixit.Checked = True Then
            StrtScrn.fixit_img.Enabled = True
            StrtScrn.fixit_img.Image = My.Resources.fixit

        Else : StrtScrn.fixit_img.Enabled = False
            StrtScrn.fixit_img.Image = My.Resources.fixit_dis
        End If


        If opt_mov.Checked = True Then
            StrtScrn.mov_img.Enabled = True
            StrtScrn.mov_img.Image = My.Resources.mov1

        Else : StrtScrn.mov_img.Enabled = False
            StrtScrn.mov_img.Image = My.Resources.mov1_dis
        End If

        If opt_math.Checked = True Then
            StrtScrn.math_img.Enabled = True
            StrtScrn.math_img.Image = My.Resources.math3


        Else : StrtScrn.math_img.Enabled = False
            StrtScrn.math_img.Image = My.Resources.math3_dis
        End If



        If opt_xplr.Checked = True Then
            StrtScrn.xplore_img.Enabled = True
            StrtScrn.xplore_img.Image = My.Resources.xplore
        Else : StrtScrn.xplore_img.Enabled = False
            StrtScrn.xplore_img.Image = My.Resources.xplore_dis
            
        End If

        'Pinned

        



        'Shortcuts

        If shrt.Checked = True Then
            StrtScrn.dipt.Visible = True
            StrtScrn.divz.Visible = True
            StrtScrn.s.Visible = True

        Else : StrtScrn.dipt.Visible = False
            StrtScrn.divz.Visible = False
            StrtScrn.s.Visible = False
        End If

        'Updates

        If up.Checked = True Then
            StrtScrn.updates_img.Enabled = True
            StrtScrn.updates_img.Image = My.Resources.refresh1


        Else
            If up.Checked = False Then

                StrtScrn.updates_img.Enabled = False
                StrtScrn.updates_img.Image = My.Resources.refresh_dis

            End If
        End If

        If up.Checked = False Then

            A.Image = My.Resources.bar1
            B.BackgroundImage = My.Resources.bar1
            If MessageBox.Show("Disabling Vifarnet updates will prevent you from recieving future updates/modifications/ and Vifarnet will be outdated with a few problems. It is not recommended that you turn off Vifarnet Updates." & vbNewLine & "Are you really sure that you want to turn off Vifarnet updates??", "Confirmation: Turn off Vifarnet Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then

                StrtScrn.updates_img.Enabled = False
                StrtScrn.updates_img.Image = My.Resources.refresh_dis
                up.Checked = False
                A.Image = My.Resources.bar
                B.BackgroundImage = My.Resources.bar


            Else : up.Checked = True
                StrtScrn.updates_img.Enabled = True
                StrtScrn.updates_img.Image = My.Resources.refresh1
                A.Image = My.Resources.bar
                B.BackgroundImage = My.Resources.bar
            End If

        Else : up.Checked = True
            StrtScrn.updates_img.Enabled = True
            StrtScrn.updates_img.Image = My.Resources.refresh1
            A.Image = My.Resources.bar
            B.BackgroundImage = My.Resources.bar
        End If

        If srch.Checked = True Then
            VifFixIt.srch_adv.Enabled = True
        Else
            VifFixIt.srch_adv.Enabled = False
        End If




        '____________________________________________
        'Apps
        My.Settings.opt_music = opt_music.Checked
        My.Settings.opt_fixit = opt_fixit.Checked
        My.Settings.opt_mov = opt_mov.Checked
        My.Settings.opt_math = opt_math.Checked
        My.Settings.opt_xplr = opt_xplr.Checked

        'Pinned
        My.Settings.opt_pin = opt_pin.Checked
        My.Settings.pin_dev = pin_dev.Checked
        My.Settings.pin_dev = pin_xp.Checked
        My.Settings.pin_dev = pin_pvt.Checked

        'Shortcuts
        My.Settings.shrt = shrt.Checked

        'updates
        My.Settings.up = up.Checked


        'Search
        My.Settings.srch = srch.Checked


        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rest.Click
        If MessageBox.Show("You will loose all settings made to Vifarnet X-emplar, and default settings will be applied." & vbNewLine & "Are you sure you want to restore all default settings?", "Confirmation: Restore Default Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            opt_fixit.Checked = True
            opt_math.Checked = True
            opt_mov.Checked = True
            opt_music.Checked = True
            opt_xplr.Checked = True

            up.Checked = True
            shrt.Checked = False
            srch.Checked = True

            '____________________________________________


            ok.PerformClick()


        Else : My.Settings.Save()
        End If
    End Sub

    Private Sub no_Cflick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.Click
        Me.Close()
    End Sub

    Private Sub ctrl_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Apps
        opt_music.Checked = My.Settings.opt_music
        opt_fixit.Checked = My.Settings.opt_fixit
        opt_mov.Checked = My.Settings.opt_mov
        opt_math.Checked = My.Settings.opt_math
        opt_xplr.Checked = My.Settings.opt_xplr

        'Pinned
      


        'Shortcuts
        shrt.Checked = My.Settings.shrt

        'Updates
        up.Checked = My.Settings.up

        'Search
        srch.Checked = My.Settings.srch
    End Sub

    Private Sub no_Cldfick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseEnter
        ok.BackgroundImage = My.Resources.bar22
    End Sub
    Private Sub no_Cldxfcdick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseLeave
        ok.BackgroundImage = Nothing
    End Sub


    Private Sub ok_Clsick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.MouseEnter
        no.BackgroundImage = My.Resources.bar12
    End Sub
    Private Sub ok_Clcdcdick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.MouseLeave
        no.BackgroundImage = Nothing
    End Sub



    Private Sub no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rest.MouseEnter
        rest.BackgroundImage = My.Resources.bar3
    End Sub
    Private Sub no_Clcdick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rest.MouseLeave
        rest.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox3s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.MouseEnter
        pb1.BackgroundImage = My.Resources.bar12
    End Sub
    Private Sub PictureBosx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.MouseLeave
        pb1.BackgroundImage = Nothing
    End Sub

    Private Sub PicturdeBox3s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l.MouseEnter
        pb1.BackgroundImage = My.Resources.bar12
    End Sub
    Private Sub PictureaBosx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l.MouseLeave
        pb1.BackgroundImage = Nothing
    End Sub


    Private Sub PicturdedBox3s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb.MouseEnter
        pb1.BackgroundImage = My.Resources.bar12
    End Sub
    Private Sub PictsureaBosx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb.MouseLeave
        pb1.BackgroundImage = Nothing
    End Sub

End Class