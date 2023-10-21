Public Class Form6
    'Create a design for a program that will use  the menus and functions that will allow the user to accept the selection of one 
    'of the three flooring options for a home using input box and the quantity of the selected option. The program also provides a description
    'of the flooring options. Display the option the user chooses the description, and the price upon clicking the display menu.
    Dim option1, option2, option3, quantity, price, ttl As Integer

    Private Sub Option3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Option3ToolStripMenuItem.Click
        option3 = InputBox("Wood floors in the living area, carpeting in the bedroom, and tile in the bath area for Php 100000", "Price", 0, 200, 200)
        price = 100000
        ttl = CalculatePrice(option3, price)
        MsgBox("Option 3: Wood floors in the living area, carpeting in the bedroom, and tile in the bath area for Php " + ttl.ToString)
    End Sub

    Private Sub Option1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Option1ToolStripMenuItem.Click
        option1 = InputBox("Tiled, concrete for Php 55000", "Price", 0, 200, 200)
        price = 55000
        ttl = CalculatePrice(option1, price)
        MsgBox("Option 1: Tiled, concrete for Php " + ttl.ToString)
    End Sub


    Private Sub Option2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Option2ToolStripMenuItem.Click
        option2 = InputBox("Carpeting, tiled for Php 70000", "Price", 0, 200, 200)
        price = 70000
        ttl = CalculatePrice(option2, price)
        MsgBox("Option 2: Carpeting, tiled for Php " + ttl.ToString)
    End Sub
End Class