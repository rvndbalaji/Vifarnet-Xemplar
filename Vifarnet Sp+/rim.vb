Public Class rim

    Private Sub rim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Dim I As Integer
        Dim tone As String
        tone = "C:\Windows\Media\Windows Alarm Notification.wav"
        ' Loop 100 times.


            If My.Computer.FileSystem.FileExists(tone) Then

            My.Computer.Audio.Play(tone)

        Else

            For I = 1 To I = 100
                Beep()

            Next I
        End If

       
    End Sub

    Private Sub rim_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usr.Text = Vifmt.user.Text & "! you have something to do, remember? "

        des.Text = My.Settings.r1.Item(0)
        title.Text = My.Settings.r1.Item(1)
        dte.Text = My.Settings.r1.Item(2)


    End Sub

    Private Sub rest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rest.Click
        Me.Close()
        Vifmt.Close()
    End Sub

   
End Class