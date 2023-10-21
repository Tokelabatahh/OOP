Public Class Form1
    Dim size, top1, top2, top3 As String
    Dim toppings


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkbacon.CheckState = 0
        chkcheese.CheckState = 0
        chkpineapple.CheckState = 0
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'check size
        If optsolo.Checked = True Then
            size = "Pizza Size: " & optsolo.Text
        ElseIf optdouble.Checked = True Then
            size = "Pizza Size: " & optdouble.Text
        ElseIf optdouble.Checked = True Then
            size = "Pizza Size: " & optfamily.Text
        End If
        'check additional settings
        If chkpineapple.Checked Then
            top1 = chkpineapple.Text
        End If
        If chkcheese.Checked Then
            top2 = chkcheese.Text
        End If
        If chkbacon.Checked Then
            top3 = chkbacon.Text
        End If
        'concatenate the selected toppings
        toppings = "Toppings: " & top1 & " " & top2 & " " & top3
        'display the selected pizza and toppings and clear the selected toppings once the message box disappear
        Dim ans = MsgBox(size + "" + toppings, vbOKOnly + vbInformation, "Selected Pizza and Toppings")
        If ans = vbOK Then 'clear the selected toppings
            chkbacon.CheckState = 0
            chkcheese.CheckState = 0
            chkpineapple.CheckState = 0
            top1 = ""
            top2 = ""
            top3 = ""

        End If
    End Sub
End Class
