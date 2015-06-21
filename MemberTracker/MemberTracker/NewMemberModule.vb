Imports System.Data.OleDb

Public Module NewMemberModule

    Public Enum MinistryTopics
        A
        B
        C
    End Enum

    Public Function GetDataTableFromExcel(filePath As String) As DataTable
        Dim dt As New DataTable
        For i As Integer = 0 To 13
            dt.Columns.Add(i, GetType(String))
        Next

        Using fileReader As New FileIO.TextFieldParser(filePath)
            fileReader.SetDelimiters(",")
            Dim row As String()
            While Not fileReader.EndOfData
                row = fileReader.ReadFields
                dt.Rows.Add(row.ToArray)
            End While
        End Using

        Return dt
    End Function

    Public Function TranslateDTToListOfMemberHouseholds(householdDT As DataTable) As List(Of Member_Household)
        Dim newMemberHouseholds As New List(Of Member_Household)
        Dim count As Integer = 0
        Dim tempHousehold As New Member_Household
        Dim tempMember As New Member
        For Each row As DataRow In householdDT.Rows
            If count < 2 Then : count += 1 : Continue For : End If
            If Not row(0).Equals("") Then
                tempHousehold = Member_Household.BuildMemberHouseholdFromRow(row)
            Else
                tempMember = Member.BuildMemberFromRow(row)
                tempHousehold.Household_Members.Add(tempMember)
            End If
            If Not householdDT.Rows(count)(0).Equals("") Then : newMemberHouseholds.Add(tempHousehold) : End If
            count += 1
        Next

        Return newMemberHouseholds
    End Function

    Public Function WriteMemberHouseholdsToFile(households As List(Of Member_Household), outputPath As String) As Boolean


        Return False
    End Function

#Region "HouseHoldColumnHeaders"
    Private Const HouseHold_A As String = "Household_ID"
    Private Const HouseHold_B As String = "Date Joined Church"
    Private Const HouseHold_C As String = "Address"
    Private Const HouseHold_D As String = "City"
    Private Const HouseHold_E As String = "State"
    Private Const HouseHold_F As String = "Zip"
    Private Const HouseHold_G As String = "Home Phone"
    Private Const HouseHold_H As String = "Cell Phone"
    Private Const HouseHold_I As String = "Email Address"
    Private Const HouseHold_J As String = "Picture Path"
    Private Const HouseHold_K As String = ""
    Private Const HouseHold_L As String = ""
    Private Const HouseHold_M As String = ""
#End Region

#Region "MemberColumnHeaders"
    Private Const Member_A As String = ""
    Private Const Member_B As String = "Member_ID"
    Private Const Member_C As String = "First Name"
    Private Const Member_D As String = "Last Name"
    Private Const Member_E As String = "Date of Birth"
    Private Const Member_F As String = "Age"
    Private Const Member_G As String = "Spouse_ID"
    Private Const Member_H As String = "Anniversary Date"
    Private Const Member_I As String = "Baptized"
    Private Const Member_J As String = "Received Salvation"
    Private Const Member_K As String = "Share Information"
    Private Const Member_L As String = "Ministry Topics"
    Private Const Member_M As String = "Attended Orientation"
    Private Const Member_N As String = "Orientation Date"
#End Region

End Module
