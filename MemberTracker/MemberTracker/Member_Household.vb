Public Class Member_Household

    Public Property ID As String = ""
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
            .Address = row(1), _
            .CellPhone = row(6), _
            .City = row(2), _
            .EmailAddress = row(7), _
            .HomePhone = row(5), _
            .Household_Members = New List(Of Member), _
            .ID = row(0), _
            .PicturePath = row(8), _
            .State = row(3), _
            .ZipCode = row(4)
            }
        Return newMemberHouse
    End Function

End Class
