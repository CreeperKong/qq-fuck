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
            If EnterToolStripMenuItem.Checked = True Then
                SendKeys.Send("{Enter}")
            End If
            If CtrlEnterToolStripMenuItem.Checked = True Then
                SendKeys.Send("^{Enter}")
            End If
            If AltEnterToolStripMenuItem.Checked = True Then
                SendKeys.Send("%{Enter}")
            End If
            If ShiftEnterToolStripMenuItem.Checked = True Then
                SendKeys.Send("+{Enter}")
            End If
            Threading.Thread.Sleep(t)
            c = c - 1
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
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

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub CtrlEnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CtrlEnterToolStripMenuItem.Click
        EnterToolStripMenuItem.Checked = False
        AltEnterToolStripMenuItem.Checked = False
        ShiftEnterToolStripMenuItem.Checked = False
    End Sub

    Private Sub EnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterToolStripMenuItem.Click
        CtrlEnterToolStripMenuItem.Checked = False
        AltEnterToolStripMenuItem.Checked = False
        ShiftEnterToolStripMenuItem.Checked = False
    End Sub

    Private Sub AltEnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltEnterToolStripMenuItem.Click
        CtrlEnterToolStripMenuItem.Checked = False
        EnterToolStripMenuItem.Checked = False
        ShiftEnterToolStripMenuItem.Checked = False
    End Sub

    Private Sub ShiftEnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftEnterToolStripMenuItem.Click
        CtrlEnterToolStripMenuItem.Checked = False
        EnterToolStripMenuItem.Checked = False
        AltEnterToolStripMenuItem.Checked = False
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 免责声明ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 免责声明ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End    '退出后关闭软件
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 发送按键ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送按键ToolStripMenuItem.Click

    End Sub

    Private Sub 剪切ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切ToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub 复制ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub 粘贴ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴ToolStripMenuItem.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub 撤销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤销ToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub 重做ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重做ToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

End Class