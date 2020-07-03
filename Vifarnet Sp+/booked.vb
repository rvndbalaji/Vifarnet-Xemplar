
Public Class lstbk

    Private Sub list_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list.Click


    End Sub

    Private Sub lstasfbk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Vifmt.WindowState = FormWindowState.Normal

    End Sub

    Private Sub lstbk_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.list.Items.Add(My.Settings.r1.Item(1))
    End Sub
    Private Sub lstbk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub list_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list.DoubleClick
        If list.SelectedIndex = 1 Then
            MessageBox.Show(Vifmt.dt.Text & vbNewLine & Vifmt.title.Text & vbNewLine & Vifmt.des.Text)

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(list.SelectedIndex)
    End Sub
End Class