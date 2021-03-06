﻿Public Class MemberControl

    Public Event UpdateCurrentNodeTag(member As Member, household As Member_Household)
    Public Event DeleteMember(member As Member)
    Private _currentMember As Member

    Public Sub PopulateSpouseCBO(spouseList As List(Of Tuple(Of Integer, String)))
        Dim spouseDT As New DataTable
        spouseDT.Columns.Add("ID")
        spouseDT.Columns.Add("SpouseName")

        For Each potentialSpouse As Tuple(Of Integer, String) In spouseList
            spouseDT.Rows.Add(potentialSpouse.Item1, potentialSpouse.Item2)
        Next

        spouseDT.Rows.InsertAt(spouseDT.NewRow, 0)

        cboSpouse.DataSource = spouseDT
        cboSpouse.DisplayMember = "SpouseName"
        cboSpouse.ValueMember = "ID"
    End Sub

    Public Sub PassMemberToControl(currentMember As Member)
        txtID.Text = currentMember.ID
        txtFirstName.Text = currentMember.FirstName
        txtLastName.Text = currentMember.LastName
        dtpDOB.Value = currentMember.DateOfBirth
        txtAge.Text = CInt(DateTime.Now.Subtract(currentMember.DateOfBirth).TotalDays / 365).ToString
        dtpJoinedChurch.Value = currentMember.JoinedChurch
        txtMinistryTopics.Text = currentMember.MinistryTopicInterest
        If currentMember.Spouse_ID > 0 Then
            chkMarried.Checked = True
            cboSpouse.SelectedValue = currentMember.Spouse_ID
            dtpAnniversaryDate.Value = currentMember.AnniversaryDate
        End If
        chkBaptized.Checked = currentMember.Baptized
        chkSalvation.Checked = currentMember.Salvation
        chkShareInformation.Checked = currentMember.ShareInformation
        chkAttendedOrientation.Checked = currentMember.AttendedNewMemberClass
        If currentMember.AttendedNewMemberClass Then
            dtpOrientationDate.Value = currentMember.NewMemberClassDate
        End If
        chkPastorContact.Checked = currentMember.HavePastorContact
        txtNotes.Text = currentMember.Notes
        chkMemberActive.Checked = currentMember.MemberActive
        chkMemberArchived.Checked = currentMember.MemberArchived
        _currentMember = currentMember
    End Sub

    Public Function GetMemberFromControl() As Member
        Dim tempMember As New Member
        tempMember.FirstName = txtFirstName.Text
        tempMember.LastName = txtLastName.Text
        tempMember.DateOfBirth = dtpDOB.Value
        tempMember.JoinedChurch = dtpJoinedChurch.Value
        tempMember.MinistryTopicInterest = txtMinistryTopics.Text
        If chkMarried.Checked Then
            tempMember.Spouse_ID = cboSpouse.SelectedValue
            tempMember.AnniversaryDate = dtpAnniversaryDate.Value
        End If
        tempMember.Baptized = chkBaptized.Checked
        tempMember.Salvation = chkSalvation.Checked
        tempMember.ShareInformation = chkShareInformation.Checked
        tempMember.AttendedNewMemberClass = chkAttendedOrientation.Checked
        If tempMember.AttendedNewMemberClass Then
            tempMember.NewMemberClassDate = dtpOrientationDate.Value
        End If
        tempMember.Notes = txtNotes.Text
        tempMember.HavePastorContact = chkPastorContact.Checked
        tempMember.MemberActive = chkMemberActive.Checked
        tempMember.MemberArchived = chkMemberArchived.Checked
        tempMember.ID = txtID.Text
        Return tempMember
    End Function

    Private Sub chkAttendedOrientation_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttendedOrientation.CheckedChanged
        If chkAttendedOrientation.Checked Then
            dtpOrientationDate.Enabled = True
        Else
            dtpOrientationDate.Enabled = False
        End If
    End Sub

    Private Sub chkMarried_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarried.CheckedChanged
        If chkMarried.Checked Then
            cboSpouse.Enabled = True
            dtpAnniversaryDate.Enabled = True
        Else
            cboSpouse.Enabled = False
            dtpAnniversaryDate.Enabled = False
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = CInt(DateTime.Now.Subtract(dtpDOB.Value).TotalDays / 365).ToString
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        _currentMember = GetMemberFromControl()
        RaiseEvent UpdateCurrentNodeTag(_currentMember, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Member will be permanently deleted. Press OK to proceed or Cancel to quit.", "Are you sure?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            RaiseEvent DeleteMember(GetMemberFromControl())
        End If
    End Sub

    Private Sub MemberControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAnniversaryDate.MaxDate = DateTime.Now
        dtpDOB.MaxDate = DateTime.Now
        dtpJoinedChurch.MaxDate = DateTime.Now
        dtpOrientationDate.MaxDate = DateTime.Now
    End Sub
End Class
