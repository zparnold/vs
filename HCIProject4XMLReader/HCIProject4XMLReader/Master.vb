Imports System.Xml
Public Class Master
    Private _FunctionDoc As New XmlDocument
    Private _nodeSubset

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GeneralCommandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralCommandsToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "General Commands"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub SystemCallsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemCallsToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "General Commands"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub SubroutinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubroutinesToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "Subroutines"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub SpecialFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialFilesToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "Special Files"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub FileFormatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileFormatsToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "File Formats"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub GamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamesToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "Games"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub MacrosAndConventionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MacrosAndConventionsToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "Macros and Conventions Commands"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub MaintenanceCommandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceCommandsToolStripMenuItem.Click
        _FunctionDoc.Load("FunctionData.xml")
        Dim selection = "Maintenance Commands"
        _nodeSubset = _FunctionDoc.SelectNodes("/help/Category[@name='" + selection + "']/Command/*")
        Dim SectionForm = New Section
        SectionForm.TitleLabel.Text = SectionForm.TitleLabel.Text + " " + selection
        SectionForm.PrePopulateTreeViewControl(_nodeSubset)
        SectionForm._selection = selection
        SectionForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoadNewManPagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadNewManPagesToolStripMenuItem.Click
        Me.Hide()
        Dim some = New Welcome
        some.Show()
    End Sub
End Class