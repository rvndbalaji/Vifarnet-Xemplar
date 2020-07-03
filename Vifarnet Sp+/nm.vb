Public Class nm

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

        My.Settings.UserName = txt.Text

        Vifmt.user.Text = My.Settings.UserName





        '________________________________________________
        If Vifmt.user.Text = "...." Then

            'Reminder Visibility
            Vifmt.txt1.Visible = False
            Vifmt.dt.Visible = False
            Vifmt.title.Visible = False
            Vifmt.des.Visible = False
            Vifmt.book.Visible = False

            Vifmt.setname.Text = "Let's begin! Set your name"
            Vifmt.setname.Location = New System.Drawing.Point(287, 223)
            Vifmt.setname.Size = New System.Drawing.Size(233, 39)
            Vifmt.setname.Visible = True
        Else
            'Reminder Visibility

            Vifmt.txt1.Visible = True
            Vifmt.dt.Visible = True
            Vifmt.title.Visible = True
            Vifmt.des.Visible = True
            Vifmt.book.Visible = True


            Vifmt.setname.Text = ""
            Vifmt.setname.Size = New System.Drawing.Size(52, 39)
            Vifmt.setname.Location = New System.Drawing.Point(760, 103)



        End If

        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub nm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt.Text = My.Settings.UserName
        My.Settings.Save()

    End Sub
End Class