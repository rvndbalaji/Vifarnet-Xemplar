Public Class BG

    Private Sub BG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Vifmt.WindowState = FormWindowState.Normal
        
    End Sub

    Private Sub go1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go1.Click

        Dim wp As String

        wp = b1.Text

        If wp.Contains("www") Or wp.Contains("http") Then

            MessageBox.Show("Internet Web Images are not supported!", "URL formats not supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

        End If

        If wp.Contains("My.Resources.bar3") Then
            b1.Text = "Default()"
            go1.Enabled = False

        Else
            bg1.ImageLocation = wp

        End If



    End Sub

    Private Sub BG_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        b1.Text = My.Settings.Bg
        If b1.Text = "Default()" Then
            go1.Enabled = False

        Else : go1.Enabled = True
            b1.Text = My.Settings.Bg
            go1.PerformClick()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apply.Click
        Dim wp As String
        Dim File As String

        wp = b1.Text
        File = wp

        If wp.Contains("www") Or wp.Contains("http") Then

            MessageBox.Show("Internet Web Images are not supported!", "URL formats not supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If My.Computer.FileSystem.FileExists(File) Then

                Vifmt.BackgroundImage = System.Drawing.Image.FromFile(wp)
                Me.Close()

            Else : MessageBox.Show("Invalid file path, or file could not be found! Please try again.")
            End If

        End If


        My.Settings.Bg = wp
        My.Settings.Save()
        My.Settings.Reload()


    End Sub


    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    
    Private Sub b1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.TextChanged
        go1.Enabled = True
    End Sub
End Class