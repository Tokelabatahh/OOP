Public Class Form2
    Dim salary, pay, bonus As Decimal

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        salary = Val(txtsalary.Text)
        If salary < 6000 Then
            bonus = salary * 0.5
            opt50.Checked = True
        ElseIf salary >= 6000 And salary < 10000 Then
            bonus = salary * 0.4
            opt40.Checked = True
        ElseIf salary >= 10000 Then
            bonus = salary * 0.3
            opt30.Checked = True
        End If

        pay = salary + bonus

        lblbonus.Text = bonus
        lblpay.Text = pay
    End Sub
End Class
