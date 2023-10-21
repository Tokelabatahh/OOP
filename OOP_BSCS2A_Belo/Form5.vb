Public Class Form5
    Dim amt, unit, fee, disc As Integer
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Dispose()
    End Sub

    Private Sub mnuSub_Click(sender As Object, e As EventArgs) Handles mnuSub.Click
        DiscountType()
    End Sub

    Private Sub mnuFunctions_Click(sender As Object, e As EventArgs) Handles mnuFunctions.Click

    End Sub

    Private Sub mnuVal_Click(sender As Object, e As EventArgs) Handles mnuVal.Click
        'get the discount percentage from the user
        disc = InputBox("Discount Percentage:", "Discount", 0, 200, 200)
        fee = InputBox("Tuition Fee:", "Tuition", 0, 200, 200)
        amt = CalculateDiscount(disc, fee)
        MsgBox("Discount: " + amt.ToString, vbOKOnly + vbInformation, "Tuition Discount")
    End Sub

    Private Sub mnuRef_Click(sender As Object, e As EventArgs) Handles mnuRef.Click
        'get the  amount from the user
        amt = InputBox("Amount per Unit:", "Amount", 0, 200, 200)
        unit = InputBox("Total units:", "Units", 0, 200, 200)
        'pass the value of amount and total units
        fee = ComputeFee(amt, unit) 'calling ComputeFee function
        'display the coputed fee
        MsgBox("Amount Per Unit: " + amt.ToString + vbLf + "Total Units: " + unit.ToString + vbLf + "Total Fee: " + fee.ToString)
    End Sub
End Class