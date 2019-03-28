<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.程序ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.免责声明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.发送按键ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtrlEnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltEnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftEnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.撤销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重做ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "开始" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(一旦开始无法结束)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(405, 239)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "请输入刷屏内容"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "0.5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(152, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "间隔（秒）"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "次数"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(338, 282)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 21)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "50"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.程序ToolStripMenuItem, Me.编辑ToolStripMenuItem, Me.发送按键ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 25)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '程序ToolStripMenuItem
        '
        Me.程序ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.免责声明ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.程序ToolStripMenuItem.Name = "程序ToolStripMenuItem"
        Me.程序ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.程序ToolStripMenuItem.Text = "程序"
        '
        '免责声明ToolStripMenuItem
        '
        Me.免责声明ToolStripMenuItem.Name = "免责声明ToolStripMenuItem"
        Me.免责声明ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.免责声明ToolStripMenuItem.Text = "免责声明"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '发送按键ToolStripMenuItem
        '
        Me.发送按键ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EnterToolStripMenuItem, Me.CtrlEnterToolStripMenuItem, Me.AltEnterToolStripMenuItem, Me.ShiftEnterToolStripMenuItem})
        Me.发送按键ToolStripMenuItem.Name = "发送按键ToolStripMenuItem"
        Me.发送按键ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.发送按键ToolStripMenuItem.Text = "选项"
        '
        'EnterToolStripMenuItem
        '
        Me.EnterToolStripMenuItem.Checked = True
        Me.EnterToolStripMenuItem.CheckOnClick = True
        Me.EnterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnterToolStripMenuItem.Name = "EnterToolStripMenuItem"
        Me.EnterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnterToolStripMenuItem.Text = "Enter"
        '
        'CtrlEnterToolStripMenuItem
        '
        Me.CtrlEnterToolStripMenuItem.CheckOnClick = True
        Me.CtrlEnterToolStripMenuItem.Name = "CtrlEnterToolStripMenuItem"
        Me.CtrlEnterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CtrlEnterToolStripMenuItem.Text = "Ctrl+Enter"
        '
        'AltEnterToolStripMenuItem
        '
        Me.AltEnterToolStripMenuItem.CheckOnClick = True
        Me.AltEnterToolStripMenuItem.Name = "AltEnterToolStripMenuItem"
        Me.AltEnterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltEnterToolStripMenuItem.Text = "Alt+Enter"
        '
        'ShiftEnterToolStripMenuItem
        '
        Me.ShiftEnterToolStripMenuItem.CheckOnClick = True
        Me.ShiftEnterToolStripMenuItem.Name = "ShiftEnterToolStripMenuItem"
        Me.ShiftEnterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShiftEnterToolStripMenuItem.Text = "Shift+Enter"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.剪切ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.粘贴ToolStripMenuItem, Me.ToolStripSeparator2, Me.撤销ToolStripMenuItem, Me.重做ToolStripMenuItem, Me.ToolStripSeparator3, Me.清空ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 148)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "发送按键设置"
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.剪切ToolStripMenuItem.Text = "剪切"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.复制ToolStripMenuItem.Text = "复制"
        '
        '粘贴ToolStripMenuItem
        '
        Me.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem"
        Me.粘贴ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.粘贴ToolStripMenuItem.Text = "粘贴"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(97, 6)
        '
        '撤销ToolStripMenuItem
        '
        Me.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem"
        Me.撤销ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.撤销ToolStripMenuItem.Text = "撤销"
        '
        '重做ToolStripMenuItem
        '
        Me.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem"
        Me.重做ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.重做ToolStripMenuItem.Text = "重做"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(97, 6)
        '
        '清空ToolStripMenuItem
        '
        Me.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem"
        Me.清空ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.清空ToolStripMenuItem.Text = "清空"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "剪切"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "复制"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "粘贴"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem5.Text = "撤销"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem6.Text = "重做"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 322)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "社交软件刷屏器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 程序ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 发送按键ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CtrlEnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltEnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShiftEnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 免责声明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 剪切ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 撤销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重做ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 清空ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
End Class
