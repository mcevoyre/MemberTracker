Imports System.Data.OleDb

Public Module NewMemberModule

    Public Enum MinistryTopics
        A
        B
        C
    End Enum

    Public Function GetDataTableFromExcel(filePath As String, sheetName As String) As DataTable
        Dim dt As New DataTable
        For i As Integer = 0 To 13
            dt.Columns.Add(i, GetType(String))
        Next
        'Dim conn As System.Data.OleDb.OleDbConnection
        'Dim cmd As System.Data.OleDb.OleDbDataAdapter
        ' conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "datasource=" & _
        '                           filePath & ";Extended Properties=Excel 14.0;")
        'cmd = New OleDbDataAdapter("Select * From [" & sheetName & "$]", conn)
        'conn.Open()
        'cmd.Fill(dt)
        'conn.Close()

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

End Module
