Public Class Vifmt

    Private Sub Vifmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Settings.list.Insert(0, "Booked Tasks List")
       

        dt.Value = System.DateTime.Now
        nfi.Visible = False

        BG.b1.Text = My.Settings.Bg
        If My.Settings.Bg = "My.Resources.bar3" Then

        Else
            BG.b1.Text = "Default()"
            BackgroundImage = Image.FromFile(My.Settings.Bg)

        End If

        user.Text = My.Settings.UserName
        My.Settings.Save()
        My.Settings.Reload()

        If user.Text = "...." Then


            'task Visibility
            txt1.Visible = False
            dt.Visible = False
            title.Visible = False
            des.Visible = False
            book.Visible = False



            setname.Text = "Let's begin! Set your name"
            setname.Location = New System.Drawing.Point(287, 223)
            setname.Size = New System.Drawing.Size(233, 39)
            setname.Visible = True
        Else
            'task Visibility

            txt1.Visible = True
            dt.Visible = True
            title.Visible = True
            des.Visible = True
            book.Visible = True


            setname.Text = ""
            setname.Size = New System.Drawing.Size(52, 39)
            setname.Location = New System.Drawing.Point(760, 103)



        End If

    End Sub

    Private Sub setname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setname.Click
        nm.ShowDialog()

    End Sub

    Private Sub about_asfClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setname.MouseHover


        If setname.Text = "" And
           setname.Size = New System.Drawing.Size(52, 39) And
           setname.Location = New System.Drawing.Point(760, 103) Then


            setname.Text = "Change your name  "
            setname.Size = New System.Drawing.Size(193, 39)
            setname.Location = New System.Drawing.Point(619, 103)

        End If


    End Sub

    Private Sub Button1_Caflick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setname.MouseLeave


        If setname.Text = "Change your name  " And
           setname.Size = New System.Drawing.Size(193, 39) And
           setname.Location = New System.Drawing.Point(619, 103) Then


            setname.Text = ""
            setname.Size = New System.Drawing.Size(52, 39)
            setname.Location = New System.Drawing.Point(760, 103)

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change.Click
        Me.WindowState = FormWindowState.Minimized
        BG.Show()
        BG.Activate()
    End Sub

    Private Sub Bustton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change.MouseHover

        change.Text = "Change background "
        change.Size = New System.Drawing.Size(202, 39)
        change.Location = New System.Drawing.Point(610, 148)

    End Sub

    Private Sub Busttoan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change.MouseLeave

        change.Text = ""
        change.Size = New System.Drawing.Size(52, 39)
        change.Location = New System.Drawing.Point(760, 148)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click

        If MessageBox.Show("'My Tasks' will restore all features back to it's default form, including Background customizations and User settings [you name etc]. However, the Tasks which you've booked will be preserved. " & vbNewLine & "Are you sure you want to restore all settings of 'My Tasks'?", "Restore defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            My.Settings.Reset()
            My.Settings.UserName = "...."
            user.Text = My.Settings.UserName
            My.Settings.Save()
            My.Settings.Reload()

            If MessageBox.Show("Default settings have been applied. You'll have to restart the App in order to continue." & vbNewLine & "My Tasks will close now.", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK Then
                Me.Close()
            End If


        Else

        End If
    End Sub

    Private Sub Busstadton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.MouseHover

        reset.Text = "Restore default settings "
        reset.Size = New System.Drawing.Size(220, 39)
        reset.Location = New System.Drawing.Point(592, 193)

    End Sub

    Private Sub askjfk(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.MouseLeave

        reset.Text = ""
        reset.Size = New System.Drawing.Size(52, 39)
        reset.Location = New System.Drawing.Point(760, 193)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.Click

        Me.WindowState = FormWindowState.Minimized
        abtmt.ShowDialog()
        abtmt.Activate()

    End Sub

    Private Sub Busstton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.MouseEnter

        mt_abt.Text = "About "
        mt_abt.Size = New System.Drawing.Size(109, 47)
        mt_abt.Location = New System.Drawing.Point(701, 402)

    End Sub

    Private Sub Busattoan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.MouseLeave

        mt_abt.Text = ""
        mt_abt.Size = New System.Drawing.Size(62, 47)
        mt_abt.Location = New System.Drawing.Point(750, 402)

    End Sub

    Private Sub book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book.Click

        If dt.Text <= FormatDateTime(TimeOfDay) Then
            MessageBox.Show("The time of the task has already passed by. Please enter a future time.", "Past is Past!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If title.Text = Nothing Or
                title.Text = "Title/Subject" Or
                des.Text = Nothing Or
                des.Text = "Description" Then

                MessageBox.Show("The Title or the Decription field cannot be left blank or default.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If



        End If


        m.Enabled = True
        m.Start()



        My.Settings.r1.Insert(0, Me.des.Text)
        My.Settings.r1.Insert(1, Me.title.Text)
        My.Settings.r1.Insert(2, Me.dt.Text)

        'lstbk.list.Items.Add(Me.title.Text)




        My.Settings.Save()

    End Sub

    Private Sub m_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m.Tick
        If dt.Text = FormatDateTime(TimeOfDay) Then
            rim.ShowDialog()
            m.Stop()
            m.Enabled = False
        End If

    End Sub


    Private Sub ExitMyTasksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        If MessageBox.Show("If you quit now, your tasks will be cancelled. " & vbNewLine & "(It is recommended that you minimize 'My tasks' to the taskbar)" & vbNewLine & " Are you sure you want to quit?", "Quit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub about_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '...................

            nfi.Visible = False
            My.Settings.UserName = user.Text
            My.Settings.Save()
           
    End Sub

    Private Sub Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showMTasks.Click
        nfi.Visible = False
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal


    End Sub


    Private Sub nfi_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfi.MouseDoubleClick
        showMTasks.PerformClick()
    End Sub

    Private Sub Bussasgftadton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles booked.MouseHover

        booked.Text = "My booked tasks "
        booked.Size = New System.Drawing.Size(178, 39)
        booked.Location = New System.Drawing.Point(634, 257)

    End Sub

    Private Sub asksagfjfk(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles booked.MouseLeave

        booked.Text = ""
        booked.Size = New System.Drawing.Size(52, 39)
        booked.Location = New System.Drawing.Point(760, 257)

    End Sub

    Private Sub booked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles booked.Click

        lstbk.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub minsf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.Click
        My.Settings.UserName = user.Text
        My.Settings.Save()
        '________________________________

        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        nfi.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xitmt.Click
        If MessageBox.Show("If you quit now, your tasks will be cancelled. " & vbNewLine & "(It is recommended that you minimize 'My tasks' to the taskbar)" & vbNewLine & "Are you sure you want to quit?", "Quit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub Xitmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xitmt.MouseLeave
        Xitmt.BackColor = Color.Transparent
    End Sub
    Private Sub Xitmt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xitmt.MouseEnter
        Xitmt.BackColor = Color.Moccasin
    End Sub
    Private Sub min_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseEnter
        min.BackColor = Color.Moccasin
    End Sub
    Private Sub min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseLeave
        min.BackColor = Color.Transparent
    End Sub
End Class
