Imports System.Math
Public Class Dip
    Dim u, v, s1, s2, g, a, b, Al, Be, ux, c, d, diff, val, root, t1, t2, Time, i, rootve, rooti, alpha, beta As Double

    Private Sub v_vel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_vel.Click


        clr.PerformClick()


        If w.Text = Nothing Or y.Text = Nothing Then

            Me.BackColor = Color.IndianRed
            q.BackColor = Color.IndianRed
            w.BackColor = Color.IndianRed
            y.BackColor = Color.IndianRed
            r.BackColor = Color.IndianRed
            t.BackColor = Color.IndianRed
            a1.BackColor = Color.IndianRed
            a2.BackColor = Color.IndianRed
            lbl.BackColor = Color.IndianRed
            Menu1.BackgroundImage = My.Resources.bg6
            Menu2.BackgroundImage = My.Resources.bg6
            Menu1.BackgroundImageLayout = ImageLayout.Center
            Menu2.BackgroundImageLayout = ImageLayout.Center

            If MessageBox.Show("Dip Lengths cannot be Zero/Negative/ nor should the field be left BLANK!", "ERROR: Positivity", MessageBoxButtons.OK, MessageBoxIcon.Warning) = vbOK Then

                Me.BackColor = Color.White
                q.BackColor = Color.White
                w.BackColor = Color.White
                y.BackColor = Color.White
                r.BackColor = Color.White
                t.BackColor = Color.White
                a1.BackColor = Color.White
                a2.BackColor = Color.White
                lbl.BackColor = Color.Transparent
                Menu1.BackgroundImage = My.Resources.bg4
                Menu2.BackgroundImage = My.Resources.bg4
                Menu1.BackgroundImageLayout = ImageLayout.Stretch
                Menu2.BackgroundImageLayout = ImageLayout.Stretch

            End If


        Else


            '.
            '.
            '.
            '.
            '.
            '.


            Try
                'Get the number from the text box
                u = CType(q.Text, Double)
                s1 = CType(w.Text, Double)
                s2 = CType(y.Text, Double)
                a = CType(r.Text, Double)
                b = CType(t.Text, Double)
            Catch
            End Try





            If w.Text <= 0 Or y.Text <= 0 Then
                Me.BackColor = Color.IndianRed
                q.BackColor = Color.IndianRed
                w.BackColor = Color.IndianRed
                y.BackColor = Color.IndianRed
                r.BackColor = Color.IndianRed
                t.BackColor = Color.IndianRed
                a1.BackColor = Color.IndianRed
                a2.BackColor = Color.IndianRed
                lbl.BackColor = Color.IndianRed
                Menu1.BackgroundImage = My.Resources.bg6
                Menu1.BackgroundImageLayout = ImageLayout.Center
                Menu2.BackgroundImageLayout = ImageLayout.Center
                Menu2.BackgroundImage = My.Resources.bg6


                MessageBox.Show("Dip Lengths cannot be Zero/Negative/ nor should the field be left BLANK!", "ERROR: Positivity", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Me.BackColor = Color.White
                q.BackColor = Color.White
                w.BackColor = Color.White
                y.BackColor = Color.White
                r.BackColor = Color.White
                t.BackColor = Color.White
                a1.BackColor = Color.White
                a2.BackColor = Color.White
                lbl.BackColor = Color.Transparent
                Menu1.BackgroundImage = My.Resources.bg4
                Menu1.BackgroundImageLayout = ImageLayout.Stretch
                Menu2.BackgroundImageLayout = ImageLayout.Stretch
                Menu2.BackgroundImage = My.Resources.bg4

            End If


            'Multiply by Math.PI/180 to convert degrees to radians.

            alpha = (a * PI) / 180
            beta = (b * PI) / 180

            Al = Sin(alpha)
            Be = Sin(beta)

           

            'CALCULATION!..........................................

            g = 9.807

            'Mid
            c = Al * s1
            d = Be * s2

            diff = c - d

            val = 2 * g * diff

            ux = u * u

            root = ux + val

            v = root ^ (1 / 2)

            '_________________________________________________________________________
            'To calculate the time: 
            't1 = downward speed 
            't2 = upward speed
            'T = Total time [Dip speed]
            '_________________________________________________________________________


            Dim tg As Double
            Dim th As Double

            tg = g * Al
            th = g * Be

            Dim iu As Double
            Dim iv As Double
            Dim sep As Double
            Dim ix As Double

            sep = 2 * g * c
            ix = ux + sep




            Dim i As Double

            If root < 0 Then
                rootve = root * -1
                rooti = rootve ^ (1 / 2)

                'Time.........................
                i = ix ^ (1 / 2)
                iu = i - u
                iv = i - rooti

                t1 = iu / tg
                t2 = iv / th


                Time = t1 + t2

                'Answer..............

                lbl.Visible = False

                a1.Text = "(ReD) " & rooti & "i m/sec"
                a2.Text = ("t1 = " & t1 & " sec" & vbNewLine & "t2 = " & t2 & " sec" & vbNewLine & "Alpha (Al) = " & Al & vbNewLine & "Beta (Be) = " & Be & vbNewLine & "Total Time Taken = " & Time & " sec" & vbNewLine & "HSP (i) = " & i & " m/sec" & vbNewLine & "acc.(s1) = " & tg & " m/s^2" & vbNewLine & "acc.(s2) = " & th & " m/s^2")

            Else


                'Final speed (v)
                root = ux + val
                v = root ^ (1 / 2)
                '...................

                i = ix ^ (1 / 2)

                iu = i - u
                iv = i - v

                t1 = iu / tg
                t2 = iv / th

                Time = t1 + t2

                'Answer....................
                lbl.Visible = False
                a1.Text = "v = " & v & " m/sec"
                a2.Text = ("t1 = " & t1 & " sec" & vbNewLine & "t2 = " & t2 & " sec" & vbNewLine & "Alpha (Al) = " & Al & vbNewLine & "Beta (Be) = " & Be & vbNewLine & "Total Time Taken = " & Time & " sec" & vbNewLine & "HSP (i) = " & i & " m/sec" & vbNewLine & "acc.(s1) = " & tg & " m/s^2" & vbNewLine & "acc.(s2) = " & th & " m/s^2")
            End If

            lbl.Visible = False



            '.
            '.
            '.
            '.
            '.
            '.
            '.

        End If

    End Sub

    Private Sub Dip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub
    Private Sub Dip_Ldsoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed

        If math.WindowState = FormWindowState.Minimized Then
            math.WindowState = FormWindowState.Normal
        Else : StrtScrn.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clr.Click
        a1.Text = ""
        a2.Text = ""
        lbl.Visible = True
        a2.BackColor = Color.White
        a1.BackColor = Color.White
        lbl.BackColor = Color.Transparent
    End Sub

    Private Sub a2_TextgChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.MouseEnter
        a2.BackColor = Color.AliceBlue
        a1.BackColor = Color.AliceBlue
        lbl.BackColor = Color.AliceBlue
    End Sub
    Private Sub a2_TextCh4anged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.MouseEnter
        a2.BackColor = Color.AliceBlue
        a1.BackColor = Color.AliceBlue
        lbl.BackColor = Color.AliceBlue
    End Sub
    Private Sub a2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl.MouseEnter
        a2.BackColor = Color.AliceBlue
        a1.BackColor = Color.AliceBlue
        lbl.BackColor = Color.AliceBlue
    End Sub




    Private Sub a2_TexdtgChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.MouseLeave
        a2.BackColor = Color.White
        a1.BackColor = Color.White
        lbl.BackColor = Color.Transparent
    End Sub
    Private Sub a2_TextaCh4anged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.MouseLeave
        a2.BackColor = Color.White
        a1.BackColor = Color.White
        lbl.BackColor = Color.Transparent
    End Sub
    Private Sub a2_TeaqxtChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl.MouseLeave
        a2.BackColor = Color.White
        a1.BackColor = Color.White
        lbl.BackColor = Color.Transparent
    End Sub



    Private Sub m_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_name.Click
        If m_abt.Visible = True And
          m_arr.Visible = True And
          m_gotostrtpage.Visible = True And
          m_rfsh.Visible = True Then

            m_abt.Visible = False
            m_arr.Visible = False
            m_gotostrtpage.Visible = False
            m_rfsh.Visible = False


        Else
            m_abt.Visible = True
            m_arr.Visible = True
            m_rfsh.Visible = True
            m_gotostrtpage.Visible = True


        End If
    End Sub

    Private Sub m_abt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_abt.Click
        Me.BackColor = Color.Gray
        Menu1.BackgroundImage = My.Resources.gray
        Menu2.BackgroundImage = My.Resources.gray
        q.BackColor = Color.Gray
        w.BackColor = Color.Gray
        r.BackColor = Color.Gray
        t.BackColor = Color.Gray
        y.BackColor = Color.Gray
        a1.BackColor = Color.Gray
        a2.BackColor = Color.Gray

        If Dialog2.ShowDialog() = True Then
            a1.Clear()
            a2.Clear()
            Menu1.BackgroundImage = My.Resources.gray
            Menu2.BackgroundImage = My.Resources.gray
            q.BackColor = Color.Gray
            w.BackColor = Color.Gray
            r.BackColor = Color.Gray
            t.BackColor = Color.Gray
            y.BackColor = Color.Gray
            a1.BackColor = Color.Gray
            a2.BackColor = Color.Gray

        Else : Me.BackColor = Color.White
            Menu1.BackgroundImage = My.Resources.bg3
            Menu2.BackgroundImage = My.Resources.bg3
            q.BackColor = Color.White
            w.BackColor = Color.White
            r.BackColor = Color.White
            t.BackColor = Color.White
            y.BackColor = Color.White
            a1.BackColor = Color.White
            a2.BackColor = Color.White
        End If
    End Sub

    Private Sub gotostrtpage_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_txt.Click
        StrtScrn.WindowState = FormWindowState.Normal
        math.Close()
        Me.Close()

    End Sub

    Private Sub Xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        StrtScrn.block.Dock = DockStyle.Fill
        StrtScrn.block.Visible = True
        quit.ShowDialog()
    End Sub

End Class