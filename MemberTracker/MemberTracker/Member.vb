Public Class Member
    Public Property ID As String
    Public Property Households_ID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DateOfBirth As Date
    Public Property Age As Integer
    Public Property Spouse_ID As Integer
    Public Property AnniversaryDate As Date
    Public Property Baptized As Boolean
    Public Property Salvation As Boolean
    Public Property ShareInformation As Boolean
    Public Property MinistryTopicInterest As MinistryTopics
    Public Property AttendedNewMemberClass As Boolean
    Public Property NewMemberClassDate As Nullable(Of Date)

    Public Sub Member()

    End Sub

    Public Shared Function BuildMemberFromRow(row As DataRow) As Member
        Dim newMember As New Member() With {
            .Age = row(5), _
            .AnniversaryDate = row(7), _
            .AttendedNewMemberClass = row(12), _
            .Baptized = row(8), _
            .DateOfBirth = row(4), _
            .FirstName = row(2), _
            .ID = row(1), _
            .LastName = row(3), _
            .MinistryTopicInterest = [Enum].Parse(GetType(MinistryTopics), row(11)), _
            .NewMemberClassDate = If(CBool(row(12)), row(13), Nothing), _
            .Salvation = row(9), _
            .ShareInformation = row(10), _
            .Spouse_ID = row(6)}
        Return newMember
    End Function

End Class
