Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim mark As Integer

        ' Check if the input is a valid integer
        If Integer.TryParse(txtMarks.Text, mark) Then
            ' If the mark exceeds 100, show a warning
            If mark > 100 Then
                MessageBox.Show("Wrong entry, please re-enter the mark.")
                txtMarks.Clear() ' Clear the input for correction
            Else
                ' Use the Select Case statement for grading
                Select Case mark
                    Case 90 To 100
                        txtGrade.Text = "Excellent"
                    Case 80 To 89
                        txtGrade.Text = "Very Good"
                    Case 70 To 79
                        txtGrade.Text = "Good"
                    Case 60 To 69
                        txtGrade.Text = "Medium"
                    Case 50 To 59
                        txtGrade.Text = "Pass"
                    Case 0 To 49
                        txtGrade.Text = "Fail"
                End Select
            End If
        Else
            ' Show a message if the input is not a valid number
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub
End Class
