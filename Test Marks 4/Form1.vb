Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMarks.TextChanged
        Dim Mark As Integer
        'Mark = txtMark.Text
        If (IsNumeric(txtMarks.Text) = True) Then
            Mark = CInt(txtMarks.Text)
            If Mark < 0 Or Mark > 100 Then
                MsgBox("Invalid mark")
            ElseIf (Mark < 50) Then
                MsgBox("failed")
            ElseIf (Mark = 50 Or Mark > 50) Then
                MsgBox(" you have passed")
            End If
        Else
            MsgBox("you have entered a non-numeric mark try again with a number or integer")
        End If
    End Sub
End Class
