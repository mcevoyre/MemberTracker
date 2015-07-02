Public Class Member_Household

    Public Property ID As String = ""
    Public Property JoinedChurch As Date = Now
    Public Property Address As String = ""
    Public Property City As String = ""
    Public Property State As String = ""
    Public Property ZipCode As String = ""
    Public Property HomePhone As String = ""
    Public Property CellPhone As String = ""
    Public Property EmailAddress As String = ""
    Public Property PicturePath As String = ""
    Public Property Household_Members As List(Of Member)

    Public Sub Member_Household()

    End Sub

    Public Shared Function BuildMemberHouseholdFromRow(row As DataRow) As Member_Household
        Dim newMemberHouse As New Member_Household With {
            .Address = row(2), _
            .CellPhone = row(7), _
            .City = row(3), _
            .EmailAddress = row(8), _
            .HomePhone = row(6), _
            .Household_Members = New List(Of Member), _
            .ID = row(0), _
            .JoinedChurch = CDate(row(1)), _
            .PicturePath = row(9), _
            .State = row(4), _
            .ZipCode = row(5)
            }
        Return newMemberHouse
    End Function

End Class
