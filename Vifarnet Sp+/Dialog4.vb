Public Class Dialog4

    Private Sub OK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK1.Click
        Me.Close()
        pass.an.Clear()
        pass.pw.Clear()
        pass.an.Focus()
    End Sub
End Class