Public Class MenuOpciones

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Timer1.Enabled = True


    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

       ProgressBar1.Increment(1)
        ' Display the textual value of the ProgressBar in the StatusBar control's first panel.
        ProgressBar1.Text = ProgressBar1.Value.ToString() + "% Completed"
        ' Determine if we have completed by comparing the value of the Value property to the Maximum value.
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Recambio.Show()
            Me.Close()
        End If
        ' Stop the timer.


    End Sub



    Private Sub AveriasCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        ' Display the textual value of the ProgressBar in the StatusBar control's first panel.
        ProgressBar1.Text = ProgressBar1.Value.ToString() + "% Completed"
        ' Determine if we have completed by comparing the value of the Value property to the Maximum value.
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Averias.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MenuOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class