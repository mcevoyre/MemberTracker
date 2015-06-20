Public Class ReportsControl

    Public Sub PopulateNeedsOrientationReport(households As List(Of Member_Household))
        gbReports.Text = "Members who haven't attended Orientation"

        Dim dt As New DataTable
        dt.Columns.Add("FirstName", GetType(String))
        dt.Columns.Add("LastName", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("HomePhone", GetType(String))
        dt.Columns.Add("DOB", GetType(String))

        dt.Rows.Add(New Object() {"First Name", "Last Name", "Email Address", "Home Phone", "Date of Birth"})

        For Each household As Member_Household In households
            For Each Member As Member In household.Household_Members
                If Member.AttendedNewMemberClass = False Then
                    dt.Rows.Add(New Object() {Member.FirstName, Member.LastName, household.EmailAddress, _
                                              household.HomePhone, Member.DateOfBirth.ToString("dd/MM/yyyy")})
                End If
            Next
        Next

        dgvReportData.DataSource = dt
    End Sub

End Class
