Public Class pass

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim app As String
        Dim pass As String

        app = an.Text
        pass = pw.Text

       

        If app = "Private Portal" And pass = "pvtport" Then
            PvtPort.Show()
            Me.Close()
            StrtScrn.WindowState = FormWindowState.Minimized

        Else : Dialog4.ShowDialog()

        End If


    End Sub

    Private Sub pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        an.Clear()
        pw.Clear()
        an.Focus()
    End Sub
End Class