Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim s As String = Me.TextBox1.Text
        s = s.Substring(s.LastIndexOf("<trigger_error>") + Len("<trigger_error>"), s.LastIndexOf("</trigger_error>") - s.LastIndexOf("<trigger_error>") - Len("<trigger_error>"))
        


        MsgBox(s)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox(Me.TextBox1.Text.LastIndexOf("banana") = False)
    End Sub
End Class
