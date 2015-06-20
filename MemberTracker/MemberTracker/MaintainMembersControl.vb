Public Class Maintain_Members

    Public Property Member_HouseHolds As List(Of Member_Household)

    Public Enum eNodeLevel
        Household_Group
        Household
        Member
    End Enum

    Public Sub PopulateTree(householdList As List(Of Member_Household))
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(New TreeNode() With {.Text = "Households", .Tag = eNodeLevel.Household_Group})
        For Each household As Member_Household In householdList
            Dim tempHouseholdNode As New TreeNode() With {.Text = household.ID, .Tag = household}
            GetTopLevelNode.Nodes.Add(tempHouseholdNode)
            For Each member As Member In household.Household_Members
                tempHouseholdNode.Nodes.Add(New TreeNode() With {.Text = member.FirstName & " " & member.LastName, .Tag = member})
            Next
        Next
    End Sub

    Private Function GetTopLevelNode() As TreeNode
        Return TreeView1.Nodes(0)
    End Function

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Select Case FindCurrentNodeLevel()
            Case eNodeLevel.Household_Group
                SplitContainer1.Panel2.Controls.Clear()
            Case eNodeLevel.Household
                SplitContainer1.Panel2.Controls.Clear()
                HouseholdControl1.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(HouseholdControl1)
                HouseholdControl1.PassHouseholdToControl(TreeView1.SelectedNode.Tag)
            Case eNodeLevel.Member
                SplitContainer1.Panel2.Controls.Clear()
                MemberControl1.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(MemberControl1)
                MemberControl1.PassMemberToControl(TreeView1.SelectedNode.Tag)
        End Select

    End Sub

    Private Function FindCurrentNodeLevel() As eNodeLevel
        If TreeView1.SelectedNode.Parent Is Nothing Then
            Return eNodeLevel.Household_Group
        ElseIf TreeView1.SelectedNode.Parent.Parent Is Nothing Then
            Return eNodeLevel.Household
        ElseIf TreeView1.SelectedNode.Parent.Parent.Parent Is Nothing Then
            Return eNodeLevel.Member
        End If
        Return eNodeLevel.Member
    End Function

    Private Sub UpdateCurrentNode(Optional member As Member = Nothing, Optional household As Member_Household = Nothing) Handles HouseholdControl1.UpdateCurrentNodeTag, MemberControl1.UpdateCurrentNodeTag
        Select Case FindCurrentNodeLevel()
            Case eNodeLevel.Household
                TreeView1.SelectedNode.Tag = household
                TreeView1.SelectedNode.Text = household.ID
            Case eNodeLevel.Member
                TreeView1.SelectedNode.Tag = member
                TreeView1.SelectedNode.Text = member.FirstName & " " & member.LastName
        End Select

    End Sub

End Class
