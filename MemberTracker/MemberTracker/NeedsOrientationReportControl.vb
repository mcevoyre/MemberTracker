Public Class NeedsOrientationReportControl

    Private Property EmailServer As String = ""
    Private Property EmailPort As String = ""
    Private Property EmailUsername As String = ""
    Private Property EmailPassword As String = ""
    Private Property EmailSendAddress As String = ""
    Private Property EmailSendName As String = ""

    Public Sub PopulateNeedsOrientationReport(households As List(Of Member_Household))
        gbReports.Text = "Members who haven't attended Orientation"

        Dim dt As New DataTable
        dt.Columns.Add(" ", GetType(Boolean))
        dt.Columns.Add("FirstName", GetType(String))
        dt.Columns.Add("LastName", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("HomePhone", GetType(String))
        dt.Columns.Add("DOB", GetType(String))

        For Each household As Member_Household In households
            For Each Member As Member In household.Household_Members
                If Member.AttendedNewMemberClass = False Then
                    dt.Rows.Add(New Object() {False, Member.FirstName, Member.LastName, household.EmailAddress, _
                                              household.HomePhone, Member.DateOfBirth.ToString("dd/MM/yyyy")})
                End If
            Next
        Next

        dgvReportData.DataSource = dt
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        If btnSelectAll.Text = "Select All" Then
            For Each row As DataRow In CType(dgvReportData.DataSource, DataTable).Rows
                row(0) = True
            Next
            btnSelectAll.Text = "Unselect All"
        ElseIf btnSelectAll.Text = "Unselect All" Then
            For Each row As DataRow In CType(dgvReportData.DataSource, DataTable).Rows
                row(0) = False
            Next
            btnSelectAll.Text = "Select All"
        End If
    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        For Each row As DataRow In CType(dgvReportData.DataSource, DataTable).Rows
            If row(0) = True Then
                NewMemberModule.SendEmailToMember(EmailServer, EmailPort, EmailUsername, EmailPassword, _
                                                  EmailSendAddress, EmailSendName, row(3), row(1) & " " & row(2), txtEmailBody.Text, txtEmailSubject.Text)
            End If
        Next
    End Sub

    Public Sub PassEmailTemplateToControl(template As String)
        txtEmailBody.Text = template
    End Sub

    Public Sub PassEmailServerConfig(server As String, port As String, username As String, password As String, _
                                     emailAddress As String, emailSendName As String)
        EmailServer = server
        EmailPort = port
        EmailUsername = username
        EmailPassword = password
        EmailSendAddress = emailAddress
        EmailSendName = emailSendName
    End Sub
End Class
