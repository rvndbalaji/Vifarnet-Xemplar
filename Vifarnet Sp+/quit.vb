Public Class quit

    Private Sub Label1a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Click
        End
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.Click

        StrtScrn.Visible = False
        StrtScrn.Close()
        b.Enabled = False
        b_txt.Text = "(Start Screen is closed)"
        b_txt.TextAlign = ContentAlignment.MiddleCenter
        b_txt.Location = New System.Drawing.Point(363, 110)

    End Sub

    Private Sub quit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        StrtScrn.block.Dock = DockStyle.None

    End Sub




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.MouseEnter
        a_txt.ForeColor = Color.White

    End Sub
    Private Sub Label1_Clizdfgck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.MouseLeave
        a_txt.ForeColor = Color.Black

    End Sub

    Private Sub Labael1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.MouseEnter
        b_txt.ForeColor = Color.White

    End Sub
    Private Sub Labd_Clizdfgck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.MouseLeave
        b_txt.ForeColor = Color.Black

    End Sub
    Private Sub Xit_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        StrtScrn.block.Visible = False
        Me.Close()
    End Sub
    Private Sub Xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.MouseLeave
        Xit.BackColor = Color.Transparent
    End Sub
    Private Sub Xit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.MouseEnter
        Xit.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub quit_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrtScrn.Visible = True Then
            b.Enabled = True
            b_txt.Text = "Only the Start Screen will be closed," & vbNewLine & " leaving other apps open (if opened)"
            b_txt.TextAlign = ContentAlignment.MiddleCenter
            b_txt.Location = New System.Drawing.Point(326, 110)

        ElseIf StrtScrn.Visible = False Then
            b.Enabled = False
            b_txt.Text = "(Start Screen is closed)"
            b_txt.TextAlign = ContentAlignment.MiddleCenter
            b_txt.Location = New System.Drawing.Point(363, 110)


        End If
    End Sub
End Class