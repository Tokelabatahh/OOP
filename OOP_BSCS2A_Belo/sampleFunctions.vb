Module sampleFunctions
    Dim fee, discount As Integer
    Function ComputeFee(ByRef amount As Integer, ByRef units As Integer)
        'compute fee
        fee = amount * units
        'pass the valus fee to compute fee function
        ComputeFee = fee
    End Function
    Function CalculateDiscount(ByVal disc As Integer, ByVal amount As Integer)
        discount = amount * disc / 100
        CalculateDiscount = discount
    End Function
    Public Sub DiscountType() 'sub procedure
        Dim type As Char
        type = InputBox("enter A, B, C only:", "Discount type",, 200, 200)
        Select Case type
            Case "a", "A"
                MsgBox("Academic Discount", vbInformation)
            Case "b", "B"
                MsgBox("Alumni Discount", vbInformation)
            Case "c", "C"
                MsgBox("Employee Discount", vbInformation)
            Case Else
                MsgBox("No Discount", vbInformation)


        End Select
    End Sub
End Module
