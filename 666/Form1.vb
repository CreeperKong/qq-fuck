Public Class Form1
    Private t As Single
    Private c As Integer
    '    Public Property Start As Boolean
    Private Sub fff()
        Do Until c = 0
            If c = 0 Then
                Exit Do
            End If
            SendKeys.Send("^V")
            If CheckBox1.Checked = True Then
                SendKeys.Send("^{Enter}")
            Else
                SendKeys.Send("{Enter}")
            End If
            Threading.Thread.Sleep(t)
            c = c - 1
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Start = True
        'Clipboard.ContainsText = True
        Clipboard.SetText(RichTextBox1.Text)
        t = Val(TextBox1.Text) * 1000
        c = Val(TextBox2.Text)
        If t >= 0.01 Then
            If c > 0 Then
                Call fff()
            Else
                MsgBox("输入错误")
            End If
        Else
            MsgBox("输入错误")
        End If
    End Sub
End Class