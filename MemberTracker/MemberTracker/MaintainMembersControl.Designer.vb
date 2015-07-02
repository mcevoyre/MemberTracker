<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintain_Members
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Member_1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Member_2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Household_1", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Member_1")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Household_2", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Members", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.csmTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHouseholdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberControl1 = New MemberControl()
        Me.HouseholdControl1 = New HouseholdControl()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.csmTree.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.MemberControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HouseholdControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(608, 512)
        Me.SplitContainer1.SplitterDistance = 202
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.csmTree
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Help
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Member_1"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "Member_2"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "Household_1"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "Member_1"
        TreeNode5.Name = "Node4"
        TreeNode5.Text = "Household_2"
        TreeNode6.Name = "Node0"
        TreeNode6.Text = "Members"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(202, 512)
        Me.TreeView1.TabIndex = 0
        '
        'csmTree
        '
        Me.csmTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMemberToolStripMenuItem, Me.AddHouseholdToolStripMenuItem})
        Me.csmTree.Name = "csmTree"
        Me.csmTree.Size = New System.Drawing.Size(158, 48)
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        Me.AddMemberToolStripMenuItem.Visible = False
        '
        'AddHouseholdToolStripMenuItem
        '
        Me.AddHouseholdToolStripMenuItem.Name = "AddHouseholdToolStripMenuItem"
        Me.AddHouseholdToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddHouseholdToolStripMenuItem.Text = "Add Household"
        Me.AddHouseholdToolStripMenuItem.Visible = False
        '
        'MemberControl1
        '
        Me.MemberControl1.Location = New System.Drawing.Point(34, 59)
        Me.MemberControl1.Name = "MemberControl1"
        Me.MemberControl1.Size = New System.Drawing.Size(397, 339)
        Me.MemberControl1.TabIndex = 1
        '
        'HouseholdControl1
        '
        Me.HouseholdControl1.Location = New System.Drawing.Point(24, 31)
        Me.HouseholdControl1.Name = "HouseholdControl1"
        Me.HouseholdControl1.Size = New System.Drawing.Size(341, 484)
        Me.HouseholdControl1.TabIndex = 0
        '
        'Maintain_Members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Maintain_Members"
        Me.Size = New System.Drawing.Size(608, 512)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.csmTree.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MemberControl1 As MemberControl
    Friend WithEvents HouseholdControl1 As HouseholdControl
    Friend WithEvents csmTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHouseholdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
