Public Class memberTracker

    Public Property MemberDT As DataTable
    Public Property MemberHouseholdList As List(Of Member_Household)

    Private Sub ConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiConfiguration.Click
        pnlMain.Controls.Clear()
        Configuration1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(Configuration1)
    End Sub

    Private Sub AddEditMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiAddEdit.Click
        pnlMain.Controls.Clear()
        Maintain_Members1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(Maintain_Members1)
        MemberDT = NewMemberModule.GetDataTableFromExcel(Configuration1.FilePath, Configuration1.SheetName)
        MemberHouseholdList = NewMemberModule.TranslateDTToListOfMemberHouseholds(MemberDT)
        Maintain_Members1.PopulateTree(MemberHouseholdList)
    End Sub

    Private Sub memberTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMain.Controls.Clear()
        WelcomeControl1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(WelcomeControl1)
    End Sub

    Private Sub NeedsOrientationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeedsOrientationToolStripMenuItem.Click
        pnlMain.Controls.Clear()
        ReportsControl1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(ReportsControl1)
        ReportsControl1.PopulateNeedsOrientationReport(MemberHouseholdList)
    End Sub
End Class
