Public Class Dialog2
    Private Sub OK2_Click_1(sender As System.Object, e As System.EventArgs) Handles OK2.Click
        Me.Close()

        If VifFixIt.Visible = True Then


            If VifFixIt.srchbox.Text = Nothing Then
                VifFixIt.srch.Visible = True
            Else : VifFixIt.srch.Visible = False
            End If

        End If
    End Sub

End Class