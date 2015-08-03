Imports System.IO
Imports System.Configuration

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
        If Not (MemberDT.Rows.Count > 0 AndAlso Not IsNothing(MemberHouseholdList)) AndAlso Configuration1.ConfigSet Then
            MemberDT = NewMemberModule.GetDataTableFromExcel(Configuration1.InputPath)
            MemberHouseholdList = NewMemberModule.TranslateDTToListOfMemberHouseholds(MemberDT)
        End If
        Maintain_Members1.PopulateTree(MemberHouseholdList)
    End Sub

    Private Sub memberTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMain.Controls.Clear()
        WelcomeControl1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(WelcomeControl1)
        Configuration1.PopulateConfigFromXMLFile(ConfigurationSettings.AppSettings("ConfigurationFileLocation"))
        If Configuration1.ConfigSet Then
            MemberDT = NewMemberModule.GetDataTableFromExcel(Configuration1.InputPath)
            MemberHouseholdList = NewMemberModule.TranslateDTToListOfMemberHouseholds(MemberDT)
        End If
    End Sub

    Private Sub NeedsOrientationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeedsOrientationToolStripMenuItem.Click
        If Not IsNothing(Maintain_Members1.GetCurrentMemberHouseholdList()) Then
            MemberHouseholdList = Maintain_Members1.GetCurrentMemberHouseholdList()
        End If
        pnlMain.Controls.Clear()
        NeedsOrientationReportControl1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(NeedsOrientationReportControl1)
        NeedsOrientationReportControl1.PopulateNeedsOrientationReport(MemberHouseholdList)
        NeedsOrientationReportControl1.PassEmailTemplateToControl(File.ReadAllText(Configuration1.EmailPath))
        NeedsOrientationReportControl1.PassEmailServerConfig(Configuration1.SMTPServer, Configuration1.SMTPPort, Configuration1.Username, Configuration1.Password, _
                                                             Configuration1.SendEmailAddress, Configuration1.SendEmailName)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Configuration1.AutoSave Then
            If Not IsNothing(Maintain_Members1.GetCurrentMemberHouseholdList()) Then
                MemberHouseholdList = Maintain_Members1.GetCurrentMemberHouseholdList()
            End If
            If Not IsNothing(Configuration1.InputPath) AndAlso Configuration1.InputPath.Length > 0 Then
                NewMemberModule.WriteMemberHouseholdsToFile(MemberHouseholdList, Configuration1.InputPath)
            End If
        End If
        Environment.Exit(0)
    End Sub

    Private Sub LoadMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadMembersToolStripMenuItem.Click
        If Not IsNothing(Configuration1.InputPath) AndAlso Configuration1.InputPath.Length > 0 Then
            MemberDT = NewMemberModule.GetDataTableFromExcel(Configuration1.InputPath)
            MemberHouseholdList = NewMemberModule.TranslateDTToListOfMemberHouseholds(MemberDT)
        End If
    End Sub

    Private Sub SaveMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMembersToolStripMenuItem.Click
        If Not IsNothing(Maintain_Members1.GetCurrentMemberHouseholdList()) Then
            MemberHouseholdList = Maintain_Members1.GetCurrentMemberHouseholdList()
        End If
        If Not IsNothing(Configuration1.InputPath) AndAlso Configuration1.InputPath.Length > 0 Then
            NewMemberModule.WriteMemberHouseholdsToFile(MemberHouseholdList, Configuration1.InputPath)
        End If
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        If Not IsNothing(Maintain_Members1.GetCurrentMemberHouseholdList()) Then
            MemberHouseholdList = Maintain_Members1.GetCurrentMemberHouseholdList()
        End If
        pnlMain.Controls.Clear()
        CustomReportControl1.Dock = DockStyle.Fill
        pnlMain.Controls.Add(CustomReportControl1)
        CustomReportControl1.PassMemberHOuseholdToControl(MemberHouseholdList)
    End Sub
End Class
