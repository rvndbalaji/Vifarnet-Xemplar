Public Class Dialog1

    Private Sub OK1_Click(sender As System.Object, e As System.EventArgs) Handles OK1.Click
        If VifFixIt.srchbox.Text = Nothing Then
            VifFixIt.srch.Visible = True
        Else : VifFixIt.srch.Visible = False
        End If

        Me.Close()
    End Sub
End Class