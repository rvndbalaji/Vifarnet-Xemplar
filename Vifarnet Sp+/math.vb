Public Class math

    Private Sub math_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DipTheory.Click
        Me.WindowState = FormWindowState.Minimized
        Dip.Show()
    End Sub

    Private Sub math_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub Cacl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cacl.Click

        Process.Start("C:\Windows\system32\calc.exe")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If My.Computer.FileSystem.FileExists("C:\Program Files\Common Files\Microsoft Shared\Ink\mip.exe") Then
            Process.Start("C:\Program Files\Common Files\Microsoft Shared\Ink\mip.exe")
        Else : Dialog2.ShowDialog()
        End If
    End Sub
End Class