Public Class Maintain_Members

    Public Property Member_HouseHolds As List(Of Member_Household)

    Public Enum eNodeLevel
        Household_Group
        Household
        Member
    End Enum

    Public Function GetCurrentMemberHouseholdList() As List(Of Member_Household)
        Return Member_HouseHolds
    End Function

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
        GetTopLevelNode.Expand()
        Member_HouseHolds = householdList
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
                Dim potentialSpouseList As New List(Of Tuple(Of Integer, String))
                Dim currentMember As Member = TreeView1.SelectedNode.Tag
                For Each householdMember As Member In CType(TreeView1.SelectedNode.Parent.Tag, Member_Household).Household_Members
                    If Not householdMember.ID = currentMember.ID Then
                        potentialSpouseList.Add(New Tuple(Of Integer, String)(householdMember.ID, householdMember.FirstName & " " & householdMember.LastName))
                    End If
                Next
                MemberControl1.PopulateSpouseCBO(potentialSpouseList)
                MemberControl1.PassMemberToControl(currentMember)
        End Select

    End Sub

    Private Function FindCurrentNodeLevel() As eNodeLevel
        If TreeView1.SelectedNode Is Nothing Then Return Nothing
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

    Private Sub TreeView1_MouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TreeView1.SelectedNode = e.Node
            Select Case FindCurrentNodeLevel()
                Case eNodeLevel.Household_Group
                    AddMemberToolStripMenuItem.Visible = False
                    AddHouseholdToolStripMenuItem.Visible = True
                    AddHouseholdToolStripMenuItem.ShowDropDown()
                Case eNodeLevel.Household
                    AddMemberToolStripMenuItem.Visible = True
                    AddHouseholdToolStripMenuItem.Visible = False
                    AddMemberToolStripMenuItem.ShowDropDown()
                Case eNodeLevel.Member
                    AddMemberToolStripMenuItem.Visible = False
                    AddHouseholdToolStripMenuItem.Visible = False
            End Select
        End If
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        Dim currentHousehold As Member_Household = TreeView1.GetNodeAt(Windows.Forms.Cursor.Position).Tag
        Dim tempNewMember As New Member()
        currentHousehold.Household_Members.Add(tempNewMember)
        Dim newMemberNode As New TreeNode() With {.Text = "New Member", .Tag = tempNewMember}
        TreeView1.SelectedNode = newMemberNode
    End Sub

    Private Sub AddHouseholdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddHouseholdToolStripMenuItem.Click
        Dim tempNewHousehold As New Member_Household
        Member_HouseHolds.Add(tempNewHousehold)
        Dim newHouseholdNode As New TreeNode() With {.Text = "New Household", .Tag = tempNewHousehold}
        GetTopLevelNode.Nodes.Add(newHouseholdNode)
        TreeView1.SelectedNode = newHouseholdNode
    End Sub

    Private Sub MaintainMembersControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainer1.Panel2.Controls.Clear()
    End Sub
End Class
