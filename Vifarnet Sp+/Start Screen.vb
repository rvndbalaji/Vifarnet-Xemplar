
Public Class StrtScrn

    '...............................................TRANSPARENCY.............................................................








    '................................................END TRANSPARENCY........................................................


    Private Sub mail_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.MouseHover
        xplore_img.BorderStyle = BorderStyle.FixedSingle
        xplore_img.Size = New System.Drawing.Size(117, 92)
        xplore_text.Visible = True
        xplore_text.Location = New System.Drawing.Point(40, 370)
    End Sub

    Private Sub mail_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.MouseLeave
        xplore_img.BorderStyle = BorderStyle.None
        xplore_img.Size = New System.Drawing.Size(90, 68)
        xplore_text.Visible = False
    End Sub
    Private Sub xplore_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.Click
        xplore.Show()
        Me.WindowState = FormWindowState.Minimized
        If xplore.WindowState = FormWindowState.Minimized Then
            xplore.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub StrtScdrn_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing

        ctrl.Close()
    End Sub
    Private Sub StrtScrn_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
        ctrl.Opacity = 0%
        ctrl.Show()
        ctrl.ok.PerformClick()
    End Sub
    Private Sub StrtScrn_dLoad_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Activate()
        A.Enabled = True
        A.Interval = 100
        A.Start()


    End Sub
    Private Sub MWa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_img.MouseHover

        m_img.BorderStyle = BorderStyle.FixedSingle
        m_img.Size = New System.Drawing.Size(117, 92)
        m_text.Visible = True
        m_text.Location = New System.Drawing.Point(46, 250)
    End Sub

    Private Sub MWa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_img.MouseLeave
        m_img.BorderStyle = BorderStyle.None
        m_img.Size = New System.Drawing.Size(90, 68)
        m_text.Visible = False

    End Sub

    Private Sub fixit_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.MouseHover
        fixit_img.BorderStyle = BorderStyle.FixedSingle
        fixit_img.Size = New System.Drawing.Size(117, 92)
        fixit_text.Visible = True
        fixit_text.Location = New System.Drawing.Point(188, 250)
    End Sub

    Private Sub fixit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.MouseLeave
        fixit_img.BorderStyle = BorderStyle.None
        fixit_img.Size = New System.Drawing.Size(90, 68)
        fixit_text.Visible = False
    End Sub
    Private Sub hlpsupsup_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseEnter

        hlpsup_img.BackColor = Color.LightSkyBlue
        hlpsup_text.Visible = True
        a1.Visible = True

        L.Stop()
        H.Start()
        s.Location = New System.Drawing.Point(370, 447)


    End Sub
    Private Sub hlpsup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseLeave

        hlpsup_img.BackColor = Color.Transparent
        hlpsup_text.Visible = False
        a1.Visible = False

        H.Stop()
        L.Start()
        s.Location = New System.Drawing.Point(417, 445)
    End Sub

    Private Sub abt_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseEnter
        abt_img.BackColor = Color.LightSkyBlue
        abt_text.Visible = True
        a2.Visible = True

        L.Stop()
        H.Start()
        s.Location = New System.Drawing.Point(370, 447)

    End Sub
    Private Sub abt_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseLeave
        abt_img.BackColor = Color.Transparent
        abt_text.Visible = False
        a2.Visible = False

        H.Stop()
        L.Start()
        s.Location = New System.Drawing.Point(417, 445)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updates_img.Click
        ud2.Show()
    End Sub
    Private Sub updates_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updates_img.MouseEnter
        updates_img.BackColor = Color.LightSkyBlue
        updates_text.Visible = True
        a3.Visible = True

        '_________________________________________________________

        L.Stop()
        H.Start()
        s.Location = New System.Drawing.Point(370, 447)

    End Sub
    Private Sub updates_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updates_img.MouseLeave
        updates_img.BackColor = Color.Transparent
        updates_text.Visible = False
        a3.Visible = False
        '_________________________________________________________
        H.Stop()
        L.Start()
        s.Location = New System.Drawing.Point(417, 445)

    End Sub

    Private Sub hlpsup_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.Click
        Beep()
        Dialog2.ShowDialog()

    End Sub

    Private Sub abt_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.Click
        abt.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Xit_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        Me.block.Dock = DockStyle.Fill
        Me.block.Visible = True
        quit.ShowDialog()

    End Sub
    Private Sub Xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.MouseLeave
        Xit.BackColor = Color.Transparent
    End Sub
    Private Sub Xit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.MouseEnter
        Xit.BackColor = Color.LightSkyBlue
    End Sub
    Private Sub min_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseEnter
        min.BackColor = Color.LightSkyBlue
    End Sub
    Private Sub min_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseLeave
        min.BackColor = Color.Transparent
    End Sub

    Private Sub fixit_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.Click
        VifFixIt.Show()
        Me.WindowState = FormWindowState.Minimized

        If VifFixIt.WindowState = FormWindowState.Minimized Then
            VifFixIt.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub mwa_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_img.Click
        music.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mov_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mov_img.MouseHover
        mov_img.BorderStyle = BorderStyle.FixedSingle
        mov_img.Size = New System.Drawing.Size(117, 92)
        mov_text.Visible = True
        mov_text.Location = New System.Drawing.Point(321, 250)
    End Sub

    Private Sub mov_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mov_img.MouseLeave
        mov_img.BorderStyle = BorderStyle.None
        mov_img.Size = New System.Drawing.Size(90, 68)
        mov_text.Visible = False
    End Sub
    Private Sub mov_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mov_img.Click
        Mov.Show()
        Me.WindowState = FormWindowState.Minimized
        If Mov.WindowState = FormWindowState.Minimized Then
            Mov.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub math_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles math_img.MouseHover
        math_img.BorderStyle = BorderStyle.FixedSingle
        math_img.Size = New System.Drawing.Size(117, 92)
        math_text.Visible = True
        math_text.Location = New System.Drawing.Point(431, 250)
    End Sub

    Private Sub math_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles math_img.MouseLeave
        math_img.BorderStyle = BorderStyle.None
        math_img.Size = New System.Drawing.Size(90, 68)
        math_text.Visible = False
    End Sub

    Private Sub math_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles math_img.Click
        Me.WindowState = FormWindowState.Minimized
        math.Show()
        math.Activate()

        Me.WindowState = FormWindowState.Minimized

        If math.WindowState = FormWindowState.Minimized Then
            math.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H.Tick

        L.Stop()
        L.Enabled = False


        ctrlc.Visible = False

        '1
        If H.Interval = 1 Then
            divx.X1 = 666
            divx.X2 = 666
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 666
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            H.Interval = 1.5


            'EX---------------------------------
        ElseIf H.Interval = 1.5 Then
            divx.X1 = 630
            divx.X2 = 630
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 630
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            H.Interval = 2
            '------------------------------------

            '2

        ElseIf H.Interval = 2 Then
            divx.X1 = 593
            divx.X2 = 593
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 593
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            H.Interval = 2.5

            'EX-----------------------------
        ElseIf H.Interval = 2.5 Then
            divx.X1 = 556
            divx.X2 = 556
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 556
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            H.Interval = 3
            '------------------------------

            '3
        ElseIf H.Interval = 3 Then
            divx.X1 = 520
            divx.X2 = 520
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 520
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

        End If

    End Sub

    Private Sub upL_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.Tick

        H.Stop()
        H.Enabled = False

        '1
        If L.Interval = 1 Then
            divx.X1 = 520
            divx.X2 = 520
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 520
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            L.Interval = 1.5

            'EX-----------------------------
        ElseIf L.Interval = 1.5 Then
            divx.X1 = 556
            divx.X2 = 556
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 656
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            L.Interval = 2
            '------------------------------

            '2

        ElseIf L.Interval = 2 Then
            divx.X1 = 593
            divx.X2 = 593
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 593
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            L.Interval = 2.5


            'EX---------------------------------
        ElseIf L.Interval = 2.5 Then
            divx.X1 = 630
            divx.X2 = 630
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 630
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429

            L.Interval = 3
            '------------------------------------


            '3
        ElseIf L.Interval = 3 Then
            divx.X1 = 666
            divx.X2 = 666
            divx.Y1 = 480
            divx.Y2 = 80

            divy.X1 = 666
            divy.X2 = 0
            divy.Y1 = 429
            divy.Y2 = 429
        End If

        ctrlc.Visible = True

    End Sub

    Private Sub Button2_sClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pvt.MouseHover

        pvt.Size = New System.Drawing.Size(148, 40)
        pvt.Text = "Private Portal"
        pvt.ImageAlign() = ContentAlignment.MiddleLeft
        Exp.Location = New System.Drawing.Point(202, 437)
    End Sub

    Private Sub Button2s_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pvt.MouseLeave

        pvt.Size = New System.Drawing.Size(40, 40)
        pvt.Text = ""
        pvt.ImageAlign() = ContentAlignment.MiddleCenter
        Exp.Location = New System.Drawing.Point(95, 437)

    End Sub

    Private Sub pvt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pvt.Click
        pass.ShowDialog()
        pass.an.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles devlog.Click
        'Process.Start("D:\Visual Basics 2010\devlog.txt")
        devlogger.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles devlog.MouseHover

        devlog.Size = New System.Drawing.Size(147, 40)
        devlog.Text = "Developer Log"
        devlog.ImageAlign() = ContentAlignment.MiddleLeft

        pvt.Location = New System.Drawing.Point(155, 437)
        Exp.Location = New System.Drawing.Point(201, 437)
    End Sub

    Private Sub Button2_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles devlog.MouseLeave

        devlog.Size = New System.Drawing.Size(40, 40)
        devlog.Text = ""
        devlog.ImageAlign() = ContentAlignment.MiddleCenter

        pvt.Location = New System.Drawing.Point(49, 437)
        Exp.Location = New System.Drawing.Point(95, 437)
    End Sub
    Private Sub Butt5on1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exp.Click
        Me.WindowState = FormWindowState.Minimized
        xp.Show()
        xp.BringToFront()
        xp.Activate()

    End Sub
    Private Sub Butto5n2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exp.MouseEnter

        Exp.Size = New System.Drawing.Size(126, 40)
        Exp.Text = "Xperiment"
        Exp.ImageAlign() = ContentAlignment.MiddleLeft


    End Sub

    Private Sub Butto5n2_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exp.MouseLeave
        Exp.Size = New System.Drawing.Size(40, 40)
        Exp.Text = ""
        Exp.ImageAlign() = ContentAlignment.MiddleCenter
    End Sub
    Private Sub xplore_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.Click
        xplore.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dipt.Click
        Dip.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ap_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Tick

        If A.Interval = 20 Then
            ap.Text = "Vifarnet is closing...."
            load3.Image = My.Resources.load20
            load3.Location = New System.Drawing.Point(302, 530)
            load3.Visible = True


        ElseIf A.Interval = 35 Then
            ap.Text = "Vifarnet is running!"
            load3.Image = My.Resources.load17
            load3.Location = New System.Drawing.Point(276, 530)
            load3.Visible = True

            A.Stop()
            A.Enabled = False

        ElseIf A.Interval = 100 Then
            load3.Image = My.Resources.load20
            load3.Location = New System.Drawing.Point(302, 530)
            ap.Text = "Starting Vifarnet...."
            A.Interval = 300

        ElseIf A.Interval = 300 Then
            ap.Text = "Activating Apps...."
            A.Interval = 350

        ElseIf A.Interval = 350 Then
            ap.Text = "Enabling links...."
            A.Interval = 400

        ElseIf A.Interval = 400 Then
            ap.Text = "Loading graphics and texts...."
            A.Interval = 600

        ElseIf A.Interval = 600 Then
            ap.Text = "Refreshing images...."
            A.Interval = 680

        ElseIf A.Interval = 680 Then
            ap.Text = "Preparing Dialog Boxes...."
            A.Interval = 700

        ElseIf A.Interval = 700 Then
            ap.Text = "Checking Vifarnet..."
            A.Interval = 750

        ElseIf A.Interval = 750 Then
            ap.Text = "Vifarnet is running!"
            load3.Image = My.Resources.load17
            load3.Location = New System.Drawing.Point(276, 530)
            load3.Visible = True

        End If

    End Sub

    Private Sub ctrlc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlc.MouseEnter
        ctrldisp.Visible = True
        ctrldisp1.Visible = True
    End Sub

    Private Sub ctrlc_Cligck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlc.MouseLeave
        ctrldisp.Visible = False
        ctrldisp1.Visible = False
    End Sub

    Private Sub ctrlc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlc.Click
        ctrl.Opacity = 100%
        ctrl.Show()
        ctrl.BringToFront()
        ctrl.Activate()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictursegsfeBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.Click
        Me.WindowState = FormWindowState.Minimized
        Vifmt.Show()
        Vifmt.Activate()
    End Sub

    Private Sub mailwf_Img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.MouseHover
        mt_img.BorderStyle = BorderStyle.FixedSingle
        mt_img.Size = New System.Drawing.Size(117, 92)
        mt_text.Visible = True
        mt_text.Location = New System.Drawing.Point(173, 370)
    End Sub

    Private Sub maiwsl_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.MouseLeave
        mt_img.BorderStyle = BorderStyle.None
        mt_img.Size = New System.Drawing.Size(90, 68)
        mt_text.Visible = False
    End Sub
End Class
