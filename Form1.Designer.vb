<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecommendedClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoonlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NVIDIASHIELDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "GameStream Desktop Agent is running!"
        Me.NotifyIcon1.BalloonTipTitle = "GmaeStream Desktop Agent"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "GameStream Desktop Agent"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ShowToolStripMenuItem, Me.QuitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(205, 120)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(204, 22)
        Me.ToolStripMenuItem6.Text = "Feedback"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ToolStripMenuItem1.Text = "Recommended clients"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "Moonlight"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem3.Text = "NVIDIA SHIELD"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'QuitToolStripMenuItem1
        '
        Me.QuitToolStripMenuItem1.Name = "QuitToolStripMenuItem1"
        Me.QuitToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.QuitToolStripMenuItem1.Text = "Quit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.QuitToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.RecommendedClientsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(397, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'RecommendedClientsToolStripMenuItem
        '
        Me.RecommendedClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoonlightToolStripMenuItem, Me.NVIDIASHIELDToolStripMenuItem})
        Me.RecommendedClientsToolStripMenuItem.Name = "RecommendedClientsToolStripMenuItem"
        Me.RecommendedClientsToolStripMenuItem.Size = New System.Drawing.Size(148, 21)
        Me.RecommendedClientsToolStripMenuItem.Text = "Recommended clients"
        '
        'MoonlightToolStripMenuItem
        '
        Me.MoonlightToolStripMenuItem.Name = "MoonlightToolStripMenuItem"
        Me.MoonlightToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MoonlightToolStripMenuItem.Text = "Moonlight"
        '
        'NVIDIASHIELDToolStripMenuItem
        '
        Me.NVIDIASHIELDToolStripMenuItem.Name = "NVIDIASHIELDToolStripMenuItem"
        Me.NVIDIASHIELDToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NVIDIASHIELDToolStripMenuItem.Text = "NVIDIA SHIELD"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(397, 157)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(389, 127)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Instructions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(389, 125)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Add this program to Game list from GeForce Experience!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HOWTO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Open GeForce E" &
    "xperience" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Go to settings > SHIELD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Add it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enjoy your access to your desk" &
    "top remotely with GameStream!"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(389, 127)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Here we GO!"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(389, 127)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Hide this and enjoy!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you want to disconnect, click Quit or hit the quit butto" &
    "n of your remote client, and the program will quit as well as you are disconnect" &
    "ed."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameStream Desktop Agent"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecommendedClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoonlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NVIDIASHIELDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
