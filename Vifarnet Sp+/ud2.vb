Public Class ud2

    Private Sub GetFileVersionInfo() Handles check.Click

        Const path = "D:\Aravind Balaji\Vifarnet\setup.exe"

        
        If My.Computer.FileSystem.FileExists(path) Then
            Process.Start(path)
            End

        Else : Dialog3.ShowDialog()

        End If

    End Sub

    Private Sub ud2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed

        StrtScrn.WindowState = FormWindowState.Normal

    End Sub
    Private Sub ud_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseEnter
        ok.BackColor = Color.OrangeRed
    End Sub

    Private Sub ok_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseLeave
        ok.BackColor = Color.DarkRed

    End Sub

End Class