Public Class Dialog5
    Private Sub OK2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK2.Click
        Me.Close()

        If VifFixIt.srchbox.Text = Nothing Then
            VifFixIt.srch.Visible = True
        Else : VifFixIt.srch.Visible = False
        End If

    End Sub

End Class