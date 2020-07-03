Imports System.IO
Public Class xplore

    Private Sub gmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Private Sub srch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label.Click
        srchbox.Focus()
    End Sub

    Private Sub srchbox_TexthgChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srchbox.TextChanged

        If srchbox.Text = Nothing Then
            label.Visible = True
        Else
            label.Visible = False
        End If
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

    Private Sub m_hlpsupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_hlpsupp.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub Xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        End
    End Sub

    Private Sub xplore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub gotostrtpage_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gotostrtpage_txt.Click
        StrtScrn.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        Mov.WindowState = FormWindowState.Minimized
        music.WindowState = FormWindowState.Minimized
        VifFixIt.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub m_rfsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_rfsh.Click
        Me.Refresh()
    End Sub

    Private Sub m_abt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_abt.Click
        Me.WindowState = FormWindowState.Minimized
        abt_xplore.Show()
        abt_xplore.Activate()
    End Sub

    Dim cnt As Integer = 0

    Private Sub srch_nor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch.Click
        label.Visible = False
        '________________________________________________



        If srchbox.Text = Nothing Then
            MessageBox.Show("You cannot leave the search field empty!", "Empty String", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else

            res.Items.Clear()
            cnt = 0
            cnt1.Text = "Ready to search"
            '.....................................

            Try

                For Each f In Directory.GetFiles("C:\", FileIO.SearchOption.SearchAllSubDirectories)

                    Dim Fn As String = My.Computer.FileSystem.GetFileInfo(f).Name

                    If Fn.Contains(srchbox.Text) Then
                        res.Items.Add(Fn)
                        cnt = cnt + 1
                    End If


                Next
                cnt1.Text = cnt & " files found!"

            Catch excpt As System.Exception
                MessageBox.Show("Something went wrong! :\")


            End Try






            '......................................
        End If











        ' Even if hidden, and so on.


        '  Do While Len(DirName) > 0

        ' Ignore the current and related directories.

        'If (DirName <> ".") And (DirName <> "..") Then






    End Sub

    Private Sub srch_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch.MouseDown
        label.Visible = False
    End Sub

    Private Sub srchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srchbox.TextChanged

        If srchbox.Text = Nothing Then
            label.Visible = True
        Else
            label.Visible = False
        End If
    End Sub
End Class