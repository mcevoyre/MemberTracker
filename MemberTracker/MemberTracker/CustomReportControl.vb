Public Class CustomReportControl

    Private MemberHouseholdList As New List(Of Member_Household)
    Private MemberDelegateDictionary As New Dictionary(Of String, Func(Of Member, String))
    Private MemberHouseholdDelegateDictionary As New Dictionary(Of String, Func(Of Member_Household, String))

    Public Sub PassMemberHOuseholdToControl(memberHouseholds As List(Of Member_Household))
        MemberDelegateDictionary.Clear()
        MemberHouseholdDelegateDictionary.Clear()
        MemberHouseholdList = memberHouseholds
        PopulateMemberDelegateDictionary()
        PopulateMemberHouseholdDelegateDictionary()
    End Sub

    Private Sub PopulateMemberDelegateDictionary()
        MemberDelegateDictionary.Add("First Name", Function(a As Member)
                                                       Return a.FirstName
                                                   End Function)
        MemberDelegateDictionary.Add("Last Name", Function(a As Member)
                                                      Return a.LastName
                                                  End Function)
        MemberDelegateDictionary.Add("Date of Birth", Function(a As Member)
                                                          Return a.DateOfBirth.ToString
                                                      End Function)
        MemberDelegateDictionary.Add("Age", Function(a As Member)
                                                Return a.Age.ToString
                                            End Function)
        MemberDelegateDictionary.Add("Spouse", Function(a As Member)
                                                   Return a.Spouse_ID.ToString
                                               End Function)
        MemberDelegateDictionary.Add("Anniversary Date", Function(a As Member)
                                                             Return a.AnniversaryDate.ToString
                                                         End Function)
        MemberDelegateDictionary.Add("Baptized", Function(a As Member)
                                                     Return a.Baptized.ToString
                                                 End Function)
        MemberDelegateDictionary.Add("Salvation", Function(a As Member)
                                                      Return a.Salvation.ToString
                                                  End Function)
        MemberDelegateDictionary.Add("Share Information", Function(a As Member)
                                                              Return a.ShareInformation.ToString
                                                          End Function)
        MemberDelegateDictionary.Add("Ministry Topic", Function(a As Member)
                                                           Return a.MinistryTopicInterest
                                                       End Function)
        MemberDelegateDictionary.Add("Attended Orientation", Function(a As Member)
                                                                 Return a.AttendedNewMemberClass.ToString
                                                             End Function)
        MemberDelegateDictionary.Add("Orientation Date", Function(a As Member)
                                                             Return a.NewMemberClassDate.ToString
                                                         End Function)
        MemberDelegateDictionary.Add("Pastor Contact", Function(a As Member)
                                                           Return a.HavePastorContact.ToString
                                                       End Function)
        MemberDelegateDictionary.Add("Notes", Function(a As Member)
                                                  Return a.Notes
                                              End Function)
        MemberDelegateDictionary.Add("Active", Function(a As Member)
                                                   Return a.MemberActive.ToString
                                               End Function)
        MemberDelegateDictionary.Add("Archived", Function(a As Member)
                                                     Return a.MemberArchived.ToString
                                                 End Function)

    End Sub

    Private Sub PopulateMemberHouseholdDelegateDictionary()
        MemberHouseholdDelegateDictionary.Add("Address", Function(a As Member_Household)
                                                             Return a.Address
                                                         End Function)
        MemberHouseholdDelegateDictionary.Add("Cell Phone", Function(a As Member_Household)
                                                                Return a.CellPhone
                                                            End Function)
        MemberHouseholdDelegateDictionary.Add("City", Function(a As Member_Household)
                                                          Return a.City
                                                      End Function)
        MemberHouseholdDelegateDictionary.Add("Email Address", Function(a As Member_Household)
                                                                   Return a.EmailAddress
                                                               End Function)
        MemberHouseholdDelegateDictionary.Add("Home Phone", Function(a As Member_Household)
                                                                Return a.HomePhone
                                                            End Function)
        MemberHouseholdDelegateDictionary.Add("Household ID", Function(a As Member_Household)
                                                                  Return a.ID
                                                              End Function)
        MemberDelegateDictionary.Add("Date Joined Church", Function(a As Member)
                                                               Return a.JoinedChurch.ToString
                                                           End Function)
        MemberHouseholdDelegateDictionary.Add("State", Function(a As Member_Household)
                                                           Return a.State
                                                       End Function)
        MemberHouseholdDelegateDictionary.Add("Zip Code", Function(a As Member_Household)
                                                              Return a.ZipCode
                                                          End Function)
        MemberHouseholdDelegateDictionary.Add("Picture Location", Function(a As Member_Household)
                                                                      Return a.PicturePath
                                                                  End Function)
    End Sub

#Region "Control Events"
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        dgvReportOutput.DataSource = Nothing
        Dim dt As New DataTable


        For Each outputElement As String In lbOutput.Items
            dt.Columns.Add(outputElement)
        Next

        Dim datarow As DataRow = dt.NewRow()
        Dim householdUsed As Boolean = False
        Dim memberUsed As Boolean = False
        For Each memberhouse As Member_Household In MemberHouseholdList

            For Each outputelement As String In lbOutput.Items
                If MemberHouseholdDelegateDictionary.ContainsKey(outputelement) Then
                    datarow(outputelement) = MemberHouseholdDelegateDictionary(outputelement)(memberhouse)
                    householdUsed = True
                End If
            Next
            If householdUsed Then : dt.Rows.Add(datarow) : End If
            datarow = dt.NewRow()
            householdUsed = False
            For Each currentMember As Member In memberhouse.Household_Members
                If chkActive.Checked AndAlso Not currentMember.MemberActive Then : Continue For : End If
                If chkArchive.Checked AndAlso Not currentMember.MemberArchived Then : Continue For : End If
                If (dtpStartDate.Checked AndAlso dtpStopDate.Checked) Then
                    If currentMember.JoinedChurch >= dtpStartDate.Value AndAlso currentMember.JoinedChurch <= dtpStopDate.Value Then
                        For Each outputelement As String In lbOutput.Items
                            If MemberDelegateDictionary.ContainsKey(outputelement) Then
                                datarow(outputelement) = MemberDelegateDictionary(outputelement)(currentMember)
                                memberUsed = True
                            End If
                        Next
                        If memberUsed Then : dt.Rows.Add(datarow) : End If
                        datarow = dt.NewRow()
                        memberUsed = False
                    End If
                Else
                    For Each outputelement As String In lbOutput.Items
                        If MemberDelegateDictionary.ContainsKey(outputelement) Then
                            datarow(outputelement) = MemberDelegateDictionary(outputelement)(currentMember)
                            memberUsed = True
                        End If
                    Next
                    If memberUsed Then : dt.Rows.Add(datarow) : End If
                    datarow = dt.NewRow()
                    memberUsed = False
                End If
                
            Next
        Next

        'Dim memberHouseholdDT As DataTable = NewMemberModule.TranslateMemberHouseholdsToDT(MemberHouseholdList)
        'Dim filterString As String = ""
        'If chkActive.Checked Then : filterString &= "16 = True" : End If
        'If chkArchive.Checked Then : filterString &= "17 = True" : End If
        'If dtpStartDate.Checked Then : filterString &= "1 >= " & dtpStartDate.Value & " And 1 <= " & dtpStopDate.Value : End If
        'memberHouseholdDT.DefaultView.RowFilter = filterString

        'dgvReportOutput.DataSource = memberHouseholdDT.DefaultView
        dgvReportOutput.DataSource = dt
    End Sub

    Private Sub btnToOutput_Click(sender As Object, e As EventArgs) Handles btnToOutput.Click
        If lbSource.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbSource.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of String)
            For Each item As String In lbSource.SelectedItems
                lbOutput.Items.Add(item)
                itemsToRemove.Add(item)
            Next
            For Each item As String In itemsToRemove
                lbSource.Items.Remove(item)
            Next
        Else
            Dim selectedItem As String = lbSource.SelectedItem
            lbOutput.Items.Add(selectedItem)
            lbSource.Items.Remove(selectedItem)
            lbOutput.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub btnToSource_Click(sender As Object, e As EventArgs) Handles btnToSource.Click
        If lbOutput.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbOutput.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of String)
            For Each item As String In lbOutput.SelectedItems
                lbSource.Items.Add(item)
                itemsToRemove.Add(item)
            Next
            For Each item As String In itemsToRemove
                lbOutput.Items.Remove(item)
            Next
        Else
            Dim selectedItem As String = lbOutput.SelectedItem
            lbSource.Items.Add(selectedItem)
            lbOutput.Items.Remove(selectedItem)
            lbSource.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub btnToTop_Click(sender As Object, e As EventArgs) Handles btnToTop.Click
        If lbOutput.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbOutput.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of Integer)
            For Each item As String In lbOutput.SelectedItems
                itemsToRemove.Add(lbOutput.Items.IndexOf(item))
            Next
            Dim count As Integer = 0
            For i As Integer = itemsToRemove.Count - 1 To 0 Step -1
                Dim currentItem As String = lbOutput.Items(itemsToRemove(i) + count)
                lbOutput.Items.Remove(currentItem)
                lbOutput.Items.Insert(0, currentItem)
                count += 1
            Next
        Else
            Dim selectedItem As String = lbOutput.SelectedItem
            lbOutput.Items.Remove(selectedItem)
            lbOutput.Items.Insert(0, selectedItem)
            lbOutput.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If lbOutput.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbOutput.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of Integer)
            For Each item As String In lbOutput.SelectedItems
                itemsToRemove.Add(lbOutput.Items.IndexOf(item))
            Next
            Dim count As Integer = 1
            For i As Integer = 0 To itemsToRemove.Count - 1
                Dim selectedItemIndex As Integer = itemsToRemove(i) + count
                Dim currentItem As String = lbOutput.Items(selectedItemIndex - count)
                lbOutput.Items.Remove(currentItem)
                lbOutput.Items.Insert(If(selectedItemIndex = 0, 0, selectedItemIndex - count - 1), currentItem)
                count += 1
            Next
        Else
            Dim selectedItem As String = lbOutput.SelectedItem
            Dim selectedItemIndex As Integer = lbOutput.Items.IndexOf(selectedItem)
            lbOutput.Items.Remove(selectedItem)
            lbOutput.Items.Insert(If(selectedItemIndex = 0, 0, selectedItemIndex - 1), selectedItem)
            lbOutput.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim listToRemove As New List(Of String)
        For Each item As String In lbOutput.SelectedItems
            listToRemove.Add(item)
        Next
        For Each item As String In listToRemove
            lbOutput.Items.Remove(item)
            lbSource.Items.Add(item)
        Next
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        If lbOutput.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbOutput.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of Integer)
            For Each item As String In lbOutput.SelectedItems
                itemsToRemove.Add(lbOutput.Items.IndexOf(item))
            Next
            Dim count As Integer = 0
            For i As Integer = 0 To itemsToRemove.Count - 1
                Dim selectedItemIndex As Integer = itemsToRemove(i) - count
                Dim currentItem As String = lbOutput.Items(selectedItemIndex + count)
                lbOutput.Items.Remove(currentItem)
                lbOutput.Items.Insert(If(selectedItemIndex = 0, 0, selectedItemIndex + count + 1), currentItem)
                count += 1
            Next
        Else
            Dim selectedItem As String = lbOutput.SelectedItem
            Dim selectedItemIndex As Integer = lbOutput.Items.IndexOf(selectedItem)
            lbOutput.Items.Remove(selectedItem)
            lbOutput.Items.Insert(If(selectedItemIndex = 0, 0, selectedItemIndex + 1), selectedItem)
            lbOutput.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub btnToBottom_Click(sender As Object, e As EventArgs) Handles btnToBottom.Click
        If lbOutput.SelectedItems.Count < 1 Then : Exit Sub : End If
        If lbOutput.SelectedItems.Count > 1 Then
            Dim itemsToRemove As New List(Of Integer)
            For Each item As String In lbOutput.SelectedItems
                itemsToRemove.Add(lbOutput.Items.IndexOf(item))
            Next
            Dim count As Integer = 0
            For i As Integer = 0 To itemsToRemove.Count - 1
                Dim currentItem As String = lbOutput.Items(itemsToRemove(i) - count)
                lbOutput.Items.Remove(currentItem)
                lbOutput.Items.Insert(lbOutput.Items.Count, currentItem)
                count += 1
            Next
        Else
            Dim selectedItem As String = lbOutput.SelectedItem
            lbOutput.Items.Remove(selectedItem)
            lbOutput.Items.Insert(lbOutput.Items.Count, selectedItem)
            lbOutput.SelectedItem = selectedItem
        End If
    End Sub

    Private Sub dtpStartDate_MouseUp(sender As Object, e As MouseEventArgs) Handles dtpStartDate.MouseUp
        If Not dtpStartDate.Checked Then
            dtpStopDate.Checked = False
        Else
            dtpStopDate.Checked = True
        End If
    End Sub

    Private Sub dtpStopDate_MouseUp(sender As Object, e As MouseEventArgs) Handles dtpStopDate.MouseUp
        If Not dtpStopDate.Checked Then
            dtpStartDate.Checked = False
        Else
            dtpStartDate.Checked = True
        End If
    End Sub

    Private Sub dtpStopDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStopDate.ValueChanged
        If dtpStopDate.Value < dtpStartDate.Value Then
            RemoveHandler dtpStopDate.ValueChanged, AddressOf dtpStopDate_ValueChanged
            dtpStopDate.Value = dtpStartDate.Value.AddDays(1)
            AddHandler dtpStopDate.ValueChanged, AddressOf dtpStopDate_ValueChanged
        End If
    End Sub

    Private Sub CustomReportControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSource.Sorted = True
        dgvReportOutput.DataSource = New DataTable()
    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        lbSource.SelectedItems.Clear()
        Dim itemList As New List(Of String)
        For Each element In lbSource.Items
            itemList.Add(element)
        Next
        For Each item As String In itemList
            lbSource.SelectedItems.Add(item)
        Next
        btnToOutput_Click(Me, Nothing)
    End Sub

    Private Sub btnDeSelectAll_Click(sender As Object, e As EventArgs) Handles btnDeSelectAll.Click
        lbOutput.SelectedItems.Clear()
        Dim itemList As New List(Of String)
        For Each element In lbOutput.Items
            itemList.Add(element)
        Next
        For Each item As String In itemList
            lbOutput.SelectedItems.Add(item)
        Next
        btnToSource_Click(Me, Nothing)
    End Sub

#End Region

End Class
