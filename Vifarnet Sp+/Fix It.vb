Public Class VifFixIt
    Private Sub hlpsup_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseEnter
        hlpsup_img.BackColor = Color.White
        hlpsup_text.Visible = True
        hlpsup_text.Location = New System.Drawing.Point(1190, 102)
        If here.Visible = True Then
            here.Visible = False
            here.Location = New System.Drawing.Point(1175, 678)
        End If
    End Sub

    Private Sub hlpsup_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseLeave
        hlpsup_img.BackColor = Color.Transparent
        hlpsup_text.Visible = False
        If here.Visible = True Then
            here.Visible = False
            here.Location = New System.Drawing.Point(1175, 678)
        End If
    End Sub

    Private Sub abt_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseEnter
        abt_img.BackColor = Color.White
        abt_text.Visible = True
        abt_text.Location = New System.Drawing.Point(1212, 102)
        If here.Visible = True Then
            here.Visible = False
            here.Location = New System.Drawing.Point(1175, 678)
        End If
    End Sub

    Private Sub abt_img_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseLeave
        abt_img.BackColor = Color.Transparent
        abt_text.Visible = False
        If here.Visible = True Then
            here.Visible = False
            here.Location = New System.Drawing.Point(1175, 678)
        End If
    End Sub

    Private Sub srch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch.Click
        srchbox.Focus()
    End Sub

    Private Sub srch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch_nor.Click
        srch.Visible = False

        '_______________________________________________________
        'DECLARATIONS

        Dim srch_item As String
        srch_item = srchbox.Text
        '_______________________________________________________


        '_______________________________________________________
        'Gadgets Repair

        If InStr(srch_item, "Gadgets") Or
            InStr(srch_item, "Gadgets repair") Or
                InStr(srch_item, "Windows gadgets repair") Or
                InStr(srch_item, "Repair Windows gadgets") Or
                InStr(srch_item, "Repair gadgets") Or
                InStr(srch_item, "How to repair Windows gadgets?") Then


            Process.Start("D:\Visual Basics 2010\Vifarnet\fixit_soln\gadget_repair.txt")

            '_______________________________________________________
            'Remove Messenger Ads

        ElseIf srch_item = "Disable Messenger ads" Or
               srch_item = "Disable Messenger advertisements" Or
               srch_item = "Disable Windows Messenger ads" Or
               srch_item = "Remove Messenger ads" Or
               srch_item = "Remove Messenger advertisements" Or
               srch_item = "Remove Windows Messenger ads" Or
               srch_item = "How to disable Messenger ads?" Or
               srch_item = "How to disable Windows Messenger ads" Or
               srch_item = "How to remove Messenger ads?" Or
               srch_item = "How to remove Windows Messenger ads" Then


            Process.Start("D:\Visual Basics 2010\Vifarnet\fixit_soln\msngr_addon_deact.txt")


            '________________________________________________________
            'HELP INFO

        ElseIf srch_item = "Help" Then
            here.Visible = True
            here.Location = New System.Drawing.Point(1272, 27)
            If MessageBox.Show("For Vifarnet Fix It help, please click the '?' icon at the top-right corner of the window." & vbNewLine & "(Indicated by moving ARROW)", "Vifarnet Help", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK Then

            End If

            '________________________________________________________
            'About Vifarnet

        ElseIf srch_item = "About" Then
            here.Visible = True
            here.Location = New System.Drawing.Point(1221, 27)
            If MessageBox.Show("For: 'About Vifarnet', please click the '!' [exclamatory] icon at the top-right corner of the window." & vbNewLine & "(Indicated by moving ARROW)", "About Vifarnet", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK Then

            End If

            '________________________________________________________
            'EXIT

        ElseIf srch_item = "Exit" Then

            If MessageBox.Show("Are you sure you want to quit?", "Quit Vifarnet Super Pro +", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Me.Close()
            End If
            '_________________________________________________________


        Else : Dialog1.ShowDialog()
        End If


    End Sub
    Private Sub srch_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch_nor.MouseDown
        srch.Visible = False
    End Sub

    Private Sub srchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srchbox.TextChanged

        If srchbox.Text = Nothing Then
            srch.Visible = True
        Else
            srch.Visible = False
        End If
    End Sub
    Private Sub VifFixIt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Private Sub abt_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.Click
        Me.WindowState = FormWindowState.Minimized
        abt_fixit.Show()
        abt_fixit.Activate()
    End Sub

    Private Sub hlpsup_img_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub srch_adv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch_adv.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub main_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_img.MouseEnter
        gotostrtpage_img.BackColor = Color.White
        gotostrtpage_text.Visible = True
        gotostrtpage_text.Location = New System.Drawing.Point(995, 102)

    End Sub
    Private Sub main_open1_Click(sender As System.Object, e As System.EventArgs) Handles gotostrtpage_img.MouseLeave
        gotostrtpage_img.BackColor = Color.Transparent
        gotostrtpage_text.Visible = False

    End Sub

    Private Sub gotostrtpage_img_Click(sender As System.Object, e As System.EventArgs) Handles gotostrtpage_img.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        Mov.WindowState = FormWindowState.Minimized
        music.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RefreshWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles m_rfsh.Click
        Me.Refresh()
    End Sub

    Private Sub m_hlpsupp_Click(sender As System.Object, e As System.EventArgs) Handles m_hlpsupp.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub m_abt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_abt.Click
        Me.WindowState = FormWindowState.Minimized
        abt_fixit.Show()
        abt_fixit.Activate()
    End Sub

    Private Sub VifarnetMainPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_txt.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        Mov.WindowState = FormWindowState.Minimized
        music.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ExitVifarnetFixItToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        StrtScrn.block.Dock = DockStyle.Fill
        StrtScrn.block.Visible = True
        quit.ShowDialog()
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
End Class

