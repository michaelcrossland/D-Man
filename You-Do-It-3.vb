Public Class Form1

    'You Do It 3
    'Darrell Schielke 3/23/2012'

    



    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim Int1 As Integer
        Dim Int2 As Integer

        Int1 = txtInt1.Text
        Int2 = txtInt2.Text
        'Recovers the input integers'
        Dim IntTotal As Integer
        Dim IntNum As Integer
        For IntNum As Integer = Int1 To Int2
            IntNum = Int1 + 1
            Int1 = Int1 + 1
            IntTotal = Int1 + IntTotal
            'Increments the Integer and adds the total'
        Next IntNum

        lblIntNum.Text = IntNum.ToString
        lblIntSum.Text = IntTotal.ToString

        'Displays the answers'
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
