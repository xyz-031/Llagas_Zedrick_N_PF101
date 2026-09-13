Imports System.Drawing.Imaging
Public Class TransparentMenuRenderer
    Inherits ToolStripRenderer

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        'Don't draw the background
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        'Don't draw the border
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        'Don't draw the item background
    End Sub

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)

        If e.Item.Selected Then
            e.TextColor = ColorTranslator.FromHtml("#bc7e31")
        Else
            e.TextColor = ColorTranslator.FromHtml("#000000")
        End If

        MyBase.OnRenderItemText(e)

    End Sub


End Class
