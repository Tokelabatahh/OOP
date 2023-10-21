Module programFunction
    Dim quantity As Integer
    Dim price, total As Decimal

    Function CalculatePrice(ByVal quantity As Integer, ByVal price As Integer)

        total = quantity * price
        CalculatePrice = total
    End Function


End Module



