'Patricia Hanus
'151125
'Perfect Square
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnPerfectSquare_Click(sender As Object, e As EventArgs) Handles btnPerfectSquare.Click
        Dim num As Integer = Val(Me.txtNum.Text)

        If PerfectSquare(num) = True Then
            Me.lblAns.Text = num & " is a perfect square."
        Else
            Me.lblAns.Text = num & " is not a perfect square."
        End If
    End Sub
    '********************************************************************************************
    'PerfectSquare 
    'Returns a True boolean if the sqrt of a number is equal to the int value of its sqrt
    '
    'post: returns a boolean value
    '********************************************************************************************
    Function PerfectSquare(ByVal num As Integer) As Boolean
        If Math.Sqrt(num) = Int(Math.Sqrt(num)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
