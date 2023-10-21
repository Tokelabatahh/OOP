Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add item in your listbox
        ListBox1.Items.Add("Banana")
        ListBox1.Items.Add("Guava")
        ListBox1.Items.Add("Apple")
        ListBox1.Items.Add("Grapes")
        ListBox1.Sorted = False
        ListBox1.Items.Clear()
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'display slected item using meassagebox
        Dim itm As String
        itm = ListBox1.Text
        MsgBox("Selected item " & itm)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'compute the sum of all num items
        Dim sum As Integer = 0
        Dim num As Integer = Integer.Parse(txtnum.Text)
        If num >= 0 Then
            'add num to listbox
            ListBox1.Items.Add(num)
            txtnum.Clear()
        Else
            For Each number As Object In ListBox1.Items
                sum += Integer.Parse(number.ToString)
            Next
            'add the sum to your lisbox
            ListBox1.Items.Add("________")
            ListBox1.Items.Add("Sum = " & sum)
        End If
    End Sub
End Class