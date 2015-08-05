Public Class Member
    Public Property ID As String = ""
    Public Property Households_ID As Integer
    Public Property FirstName As String = ""
    Public Property LastName As String = ""
    Public Property DateOfBirth As Date = Now
    Public Property Age As Integer
    Public Property Spouse_ID As Integer
    Public Property AnniversaryDate As Date = Now
    Public Property Baptized As Boolean
    Public Property Salvation As Boolean
    Public Property ShareInformation As Boolean
    Public Property MinistryTopicInterest As String = ""
    Public Property AttendedNewMemberClass As Boolean
    Public Property NewMemberClassDate As Nullable(Of Date)
    Public Property Notes As String = ""
    Public Property HavePastorContact As Boolean
    Public Property MemberActive As Boolean
    Public Property MemberArchived As Boolean
    Public Property JoinedChurch As Date = Now

    Public Sub Member()
        Dim numberGenerator As New Random()
        Me.ID = numberGenerator.Next(Integer.MinValue, Integer.MaxValue)
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
            .MinistryTopicInterest = row(11), _
            .NewMemberClassDate = If(CBool(row(12)), row(13), Nothing), _
            .Salvation = row(9), _
            .ShareInformation = row(10), _
            .Spouse_ID = row(6), _
            .Notes = row(15), _
            .HavePastorContact = CBool(row(14)), _
            .MemberActive = CBool(row(16)), _
            .MemberArchived = CBool(row(17)), _
            .JoinedChurch = row(18)}
        Return newMember
    End Function

End Class
