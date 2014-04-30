Imports System.Xml
Public Class Section
    Public _xmlNodes As New XmlDocument
    Public _selection As String

    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ScrollBars = ScrollBars.Vertical
    End Sub
    Friend Sub PrePopulateTreeViewControl(ByVal nodes As XmlNodeList)
        Dim node As XmlNode
        For Each node In nodes
            TreeView1.Nodes.Add(node.FirstChild.InnerText)
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        _xmlNodes.Load("FunctionData.xml")

        Dim some = TreeView1.SelectedNode.Index
        Dim some1 = some + 1
        Dim node = _xmlNodes.SelectSingleNode("/help/Category[@name='" + _selection + "']/Command/Name[" + some1.ToString + "]")

        TextBox1.Text = node.InnerText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim some = TreeView1.SelectedNode.Index
        Dim some1 = some + 1
        Dim node = _xmlNodes.SelectSingleNode("/help/Category[@name='" + _selection + "']/Command/Name[" + some1.ToString + "]")
        node.InnerText = TextBox1.Text
        _xmlNodes.Save("FunctionData.xml")
        MsgBox("Your Data was Saved!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim some = New Welcome
        some.Show()
    End Sub
End Class
