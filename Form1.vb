Public Class Form1
    Private Sub MoonlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoonlightToolStripMenuItem.Click
        Process.Start("https://moonlight-stream.org/")
    End Sub
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Process.Start("https://github.com/CreeperKong/GDA/issues")
    End Sub

    Private Sub NVIDIASHIELDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NVIDIASHIELDToolStripMenuItem.Click
        Process.Start("https://www.nvidia.com/shield")
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub QuitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Process.Start("https://github.com/CreeperKong/GDA/issues")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Process.Start("https://moonlight-stream.org/")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Process.Start("https://www.nvidia.com/shield")
    End Sub

End Class
