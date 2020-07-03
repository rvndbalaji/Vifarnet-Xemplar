Public Class abt_xplore

    Private Sub v_fixit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xplore.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub v_fixit_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.BackColor = Color.AliceBlue
    End Sub
    Private Sub v_fixit_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.BackColor = Color.Transparent
    End Sub

    Private Sub MouseaEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        xplore.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click
        Me.Close()
        StrtScrn.WindowState = FormWindowState.Normal
        xplore.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub logo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.Click
        xplore.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub logo2_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.BackColor = Color.AliceBlue
    End Sub
    Private Sub logo2_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.BackColor = Color.Transparent
    End Sub

    Private Sub abt_xplore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class