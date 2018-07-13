Imports System.Windows.Forms

Public Class MDIParent1
    'Declaring a childform
    Private m_ChildFormNumber As Integer


    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        'This code helps to render focus and to make mdi form a parent form
        frmConverter.MdiParent = Me
        frmConverter.Show()
        frmConverter.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit from the entire window
        Dispose()
        End
    End Sub
End Class
