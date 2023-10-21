Public Class Form3
    Dim salary, sum As Decimal
    Dim month As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        salary = Val(txtsalpermonth.Text)
        For index As Integer = 1 To 24
            If index = 1 Then
                ListBox1.Items.Add("month " & month & " " & "PHP" & salary)
            Else
                salary = salary + (salary * 0.05)
                month = month + 1
                salary = Format(salary, "###,#00.00")
                ListBox1.Items.Add("month " & month & " " & "PHP" & salary)
                sum += salary
            End If
        Next
        ListBox1.Items.Add("________")
        ListBox1.Items.Add("Sum = " & sum)
    End Sub
End Class