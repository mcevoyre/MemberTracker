Public Class MemberControl

    Public Event UpdateCurrentNodeTag(member As Member, household As Member_Household)
    Private _currentMember As Member

    Public Sub PopulateCBOs(spouseDT As DataTable)
        PopulateSpouseCBO(spouseDT)
        PopulateMinistryTopicsCBO()
    End Sub

    Private Sub PopulateSpouseCBO(spouseDT As DataTable)
        spouseDT.Rows.InsertAt(spouseDT.NewRow, 0)

        cboSpouse.DataSource = spouseDT
        cboSpouse.DisplayMember = "SpouseName"
        cboSpouse.ValueMember = "ID"
    End Sub

    Private Sub PopulateMinistryTopicsCBO()
        Dim ministryTopicDT As New DataTable
        ministryTopicDT.Columns.Add("StringValue")
        For Each ministryTopic As MinistryTopics In [Enum].GetValues(GetType(MinistryTopics))
            ministryTopicDT.Rows.Add(ministryTopic.ToString)
        Next
        ministryTopicDT.Rows.InsertAt(ministryTopicDT.NewRow, 0)

        cboMinistryTopics.DataSource = ministryTopicDT
        cboMinistryTopics.DisplayMember = "StringValue" : cboMinistryTopics.ValueMember = "StringValue"
    End Sub

    Public Sub PassMemberToControl(currentMember As Member)
        txtFirstName.Text = currentMember.FirstName
        txtLastName.Text = currentMember.LastName
        dtpDOB.Value = currentMember.DateOfBirth
        txtAge.Text = CInt(DateTime.Now.Subtract(currentMember.DateOfBirth).TotalDays / 365).ToString
        cboMinistryTopics.SelectedValue = ""
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

        _currentMember = currentMember
    End Sub

    Public Function GetMemberFromControl() As Member
        Dim tempMember As New Member
        tempMember.FirstName = txtFirstName.Text
        tempMember.LastName = txtLastName.Text
        tempMember.DateOfBirth = dtpDOB.Value
        tempMember.MinistryTopicInterest = cboMinistryTopics.SelectedValue
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
End Class
