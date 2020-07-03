Public Class abt_mov

    Private Sub v_fixit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Mov.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub v_fixit_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.BackColor = Color.AliceBlue
    End Sub
    Private Sub v_fixit_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        logo2.BackColor = Color.Transparent
    End Sub

    Private Sub MouaseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Mov.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub pic_Click(sender As System.Object, e As System.EventArgs) Handles pic.Click
        Me.Close()
        StrtScrn.WindowState = FormWindowState.Normal
        Mov.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub logo2_Click(sender As System.Object, e As System.EventArgs) Handles logo2.Click
        Mov.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
    Private Sub logo2_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.BackColor = Color.AliceBlue
    End Sub
    Private Sub logo2_Click2(sender As System.Object, e As System.EventArgs) Handles logo2.MouseLeave
        logo2.BackColor = Color.Transparent
    End Sub

    Private Sub abt_mov_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        Mov.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub abt_mov_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Mov.WindowState = FormWindowState.Minimized
    End Sub
End Class