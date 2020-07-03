
Public Class xp

    Private Sub xp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal
    End Sub

    Dim cnt As Integer = 0

    Private Sub srch_nor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch.Click

        '________________________________________________



        If srchbox.Text = Nothing Then
            MessageBox.Show("You cannot leave the search field empty!", "Empty String", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else

            res.Items.Clear()
            cnt = 0
            cnt1.Text = "Ready to search"


            For Each File In My.Computer.FileSystem.GetFiles("D:\The World in HD", FileIO.SearchOption.SearchAllSubDirectories)


                Dim Fn As String = My.Computer.FileSystem.GetFileInfo(File).Name

                If Fn.Contains(srchbox.Text) Then
                    res.Items.Add(Fn)
                    cnt = cnt + 1
                End If

            Next
            cnt1.Text = cnt & " files found!"

            ' Catch 'u As UnauthorizedAccessException

            ' End Try



        End If



    End Sub

    
End Class