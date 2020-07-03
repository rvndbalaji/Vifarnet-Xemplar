Public Class ud1

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseEnter
        ok.BackColor = Color.Lime
    End Sub

    Private Sub ok_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.MouseLeave
        ok.BackColor = Color.LimeGreen

    End Sub

    Private Sub ud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        StrtScrn.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ud_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub GetFileVersionInfo(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class