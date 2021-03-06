﻿Imports System.Net.Mail
Imports System.IO

Public Module NewMemberModule

    Public Function GetDataTableFromExcel(filePath As String, saveBackup As Boolean, backupPath As String) As DataTable
        Dim fileName As String = filePath.Split("\")(filePath.Split("\").Count - 1)
        If saveBackup Then
            File.Copy(filePath, backupPath & "\" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & "_" & fileName)
        End If

        Dim dt As New DataTable
        Try

            For i As Integer = 0 To 18
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
        Catch e As Exception

        End Try

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
                If Not tempMember.MemberArchived Then : tempHousehold.Household_Members.Add(tempMember) : End If
            End If
            If Not householdDT.Rows(count)(0).Equals("") Then : newMemberHouseholds.Add(tempHousehold) : End If
            count += 1
        Next

        Return newMemberHouseholds
    End Function

    Public Function TranslateMemberHouseholdsToDT(memberhouseholds As List(Of Member_Household)) As DataTable
        Dim dt As New DataTable
        For i As Integer = 0 To 18
            dt.Columns.Add(i, GetType(String))
        Next

        Dim count As Integer = 0
        For Each household As Member_Household In memberhouseholds
            dt.Rows.Add(New Object() {household.ID, household.Address, household.City, _
                                      household.State, household.ZipCode, household.HomePhone, household.CellPhone, _
                                      household.EmailAddress, household.PicturePath, "", "", ""})
            For Each member As Member In household.Household_Members
                dt.Rows.Add(New Object() {"", member.ID, member.FirstName, member.LastName, member.DateOfBirth, member.Age, _
                                          member.Spouse_ID, member.AnniversaryDate, member.Baptized, member.Salvation, member.ShareInformation, _
                                          member.MinistryTopicInterest, member.AttendedNewMemberClass, member.NewMemberClassDate, _
                                          member.HavePastorContact, member.Notes, member.MemberActive, member.MemberArchived, member.JoinedChurch})
            Next
        Next

        Return dt
    End Function

    Public Function WriteMemberHouseholdsToFile(households As List(Of Member_Household), outputPath As String) As Boolean
        Dim excelRowCount As Integer = 3
        Dim excelApp As Object
        Dim excelWorkbook As Object
        Dim excelWorksheet As Object
        Try
            excelApp = CreateObject("Excel.Application")
            excelApp.Application.Visible = False
            excelApp.DisplayAlerts = False
            excelWorkbook = excelApp.Workbooks.Add()
            excelWorkbook.Sheets(2).Delete()
            excelWorkbook.Sheets(2).Delete()
            excelWorkbook.Sheets(1).Sheetname = "Member Tracker Data"
            excelWorksheet = excelWorkbook.Sheets(1)
            excelWorksheet.Activate()

            WriteTwoHeaderRowsToExcel(excelWorksheet)

            For Each household As Member_Household In households
                excelWorksheet.Cells(excelRowCount, 1).Value = household.ID
                excelWorksheet.Cells(excelRowCount, 2).Value = household.Address
                excelWorksheet.Cells(excelRowCount, 3).Value = household.City
                excelWorksheet.Cells(excelRowCount, 4).Value = household.State
                excelWorksheet.Cells(excelRowCount, 5).Value = household.ZipCode
                excelWorksheet.Cells(excelRowCount, 6).Value = household.HomePhone
                excelWorksheet.Cells(excelRowCount, 7).Value = household.CellPhone
                excelWorksheet.Cells(excelRowCount, 8).Value = household.EmailAddress
                excelWorksheet.Cells(excelRowCount, 9).Value = household.PicturePath
                excelRowCount += 1
                For Each member As Member In household.Household_Members
                    excelWorksheet.Cells(2, 2).Value = member.ID
                    excelWorksheet.Cells(2, 3).Value = member.FirstName
                    excelWorksheet.Cells(2, 4).Value = member.LastName
                    excelWorksheet.Cells(2, 5).Value = member.DateOfBirth
                    excelWorksheet.Cells(2, 6).Value = member.Age
                    excelWorksheet.Cells(2, 7).Value = member.Spouse_ID
                    excelWorksheet.Cells(2, 8).Value = member.AnniversaryDate
                    excelWorksheet.Cells(2, 9).Value = member.Baptized
                    excelWorksheet.Cells(2, 10).Value = member.Salvation
                    excelWorksheet.Cells(2, 11).Value = member.ShareInformation
                    excelWorksheet.Cells(2, 12).Value = member.MinistryTopicInterest
                    excelWorksheet.Cells(2, 13).Value = member.AttendedNewMemberClass
                    excelWorksheet.Cells(2, 14).Value = member.NewMemberClassDate
                    excelWorksheet.Cells(2, 15).Value = member.HavePastorContact
                    excelWorksheet.Cells(2, 16).Value = member.Notes
                    excelWorksheet.Cells(2, 17).Value = member.MemberActive
                    excelWorksheet.Cells(2, 18).Value = member.MemberArchived
                    excelWorksheet.Cells(2, 19).Value = member.JoinedChurch
                    excelRowCount += 1
                Next
            Next

            excelApp.SaveAs(outputPath)
        Catch
            'No excel installed or other error
            Return False
        End Try
        excelApp.Workbooks.Close()
        excelApp.Quit()
        Return True
    End Function

    Private Sub WriteTwoHeaderRowsToExcel(worksheet As Object)
        worksheet.Cells(1, 1).Value = HouseHold_A
        worksheet.Cells(1, 2).Value = HouseHold_B
        worksheet.Cells(1, 3).Value = HouseHold_C
        worksheet.Cells(1, 4).Value = HouseHold_D
        worksheet.Cells(1, 5).Value = HouseHold_E
        worksheet.Cells(1, 6).Value = HouseHold_F
        worksheet.Cells(1, 7).Value = HouseHold_G
        worksheet.Cells(1, 8).Value = HouseHold_H
        worksheet.Cells(1, 9).Value = HouseHold_I

        worksheet.Cells(2, 2).Value = Member_B
        worksheet.Cells(2, 3).Value = Member_C
        worksheet.Cells(2, 4).Value = Member_D
        worksheet.Cells(2, 5).Value = Member_E
        worksheet.Cells(2, 6).Value = Member_F
        worksheet.Cells(2, 7).Value = Member_G
        worksheet.Cells(2, 8).Value = Member_H
        worksheet.Cells(2, 9).Value = Member_I
        worksheet.Cells(2, 10).Value = Member_J
        worksheet.Cells(2, 11).Value = Member_K
        worksheet.Cells(2, 12).Value = Member_L
        worksheet.Cells(2, 13).Value = Member_M
        worksheet.Cells(2, 14).Value = Member_N
        worksheet.Cells(2, 15).Value = Member_O
        worksheet.Cells(2, 16).Value = Member_P
        worksheet.Cells(2, 17).Value = Member_Q
        worksheet.Cells(2, 18).Value = Member_R
        worksheet.Cells(2, 19).Value = Member_S
    End Sub

    Private Sub WriteTwoColumnsToDataTable(householdDT As DataTable)
        householdDT.Columns.Add(HouseHold_A)
        householdDT.Columns.Add(HouseHold_B)
        householdDT.Columns.Add(HouseHold_C)
        householdDT.Columns.Add(HouseHold_D)
        householdDT.Columns.Add(HouseHold_E)
        householdDT.Columns.Add(HouseHold_F)
        householdDT.Columns.Add(HouseHold_G)
        householdDT.Columns.Add(HouseHold_H)
        householdDT.Columns.Add(HouseHold_I)
        householdDT.Columns.Add(HouseHold_J)

        householdDT.Columns.Add(Member_B)
        householdDT.Columns.Add(Member_C)
        householdDT.Columns.Add(Member_D)
        householdDT.Columns.Add(Member_E)
        householdDT.Columns.Add(Member_F)
        householdDT.Columns.Add(Member_G)
        householdDT.Columns.Add(Member_H)
        householdDT.Columns.Add(Member_I)
        householdDT.Columns.Add(Member_J)
        householdDT.Columns.Add(Member_K)
        householdDT.Columns.Add(Member_L)
        householdDT.Columns.Add(Member_M)
        householdDT.Columns.Add(Member_N)
        householdDT.Columns.Add(Member_O)
        householdDT.Columns.Add(Member_P)
        householdDT.Columns.Add(Member_Q)
        householdDT.Columns.Add(Member_R)
        householdDT.Columns.Add(Member_S)
    End Sub

    Public Function SendEmailToMember(smtpServer As String, smtpPort As String, smtpUsername As String, smtpPassword As String, _
                                      sendFromEmail As String, sendFromName As String, sendToEmail As String, _
                                      sendToName As String, messageBody As String, messageSubject As String)


        Dim smtpClient As New SmtpClient(smtpServer) With {
            .Credentials = New Net.NetworkCredential(smtpUsername, smtpPassword), _
            .EnableSsl = True, _
            .Port = smtpPort}

        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
        Dim mail As New MailMessage(New MailAddress(sendFromEmail, sendFromName), New MailAddress(sendToEmail, sendToName))
        mail.Subject = messageSubject
        mail.Body = messageBody

        smtpClient.Send(mail)
        Return True
    End Function

#Region "HouseHoldColumnHeaders"
    Private Const HouseHold_A As String = "Household_ID"
    Private Const HouseHold_B As String = "Address"
    Private Const HouseHold_C As String = "City"
    Private Const HouseHold_D As String = "State"
    Private Const HouseHold_E As String = "Zip"
    Private Const HouseHold_F As String = "Home Phone"
    Private Const HouseHold_G As String = "Cell Phone"
    Private Const HouseHold_H As String = "Email Address"
    Private Const HouseHold_I As String = "Picture Path"
    Private Const HouseHold_J As String = ""
    Private Const HouseHold_K As String = ""
    Private Const HouseHold_L As String = ""
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
    Private Const Member_O As String = "Have Pastor Contact"
    Private Const Member_P As String = "Notes"
    Private Const Member_Q As String = "Active"
    Private Const Member_R As String = "Archived"
    Private Const Member_S As String = "Date Member Joined Church"
#End Region

End Module
