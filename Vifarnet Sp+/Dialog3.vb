Public Class Dialog3
    Private Sub OK3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK3.Click
        Me.Close()
        If Shell("Explorer.exe D:\Aravind Balaji\Vifarnet\") Then

        Else : MessageBox.Show("Invalid path. Directory could not be found!", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub Dialog3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub
End Class